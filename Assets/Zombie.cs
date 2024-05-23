using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Zombie : MonoBehaviour, IEntity
{
    float time = 0;
    public Transform target;
    public NavMeshAgent agent;
    public int health { get; set; }
    public void Damage(int value)
    {
        health -= value;
        if (health <= 0) Die();
    }
    public void Die() => Destroy(this.gameObject);
    //1. 플레이어랑 거리가 가까우면 자동으로 다가오는 기능 (완료)
    //2. 플레이어랑 접촉하면 Damage() 함수를 통해 피해를 입히는 기능 (완료)
    //3. 죽으면 자기자신을 파괴하는 기능 (완료)
    // Start is called before the first frame update
    void OnEnable()
    {
        if (agent == null)
            agent = GetComponent<NavMeshAgent>();
        health = 100;
        target = GameObject.Find("Player").transform;
        time = 0;
    }
    void Update()
    {
        if (target == null) return;
        time += Time.deltaTime;
        float distance = Vector3.Distance(transform.position, target.position);
        if (distance <= 10)
        {
            agent.SetDestination(target.position);
        }
    }
    private void OnCollisionEnter(Collision other) {
        if (other.transform.CompareTag("Player"))
        {
            Debug.Log("HIT");
            if (time <= 1f && target.GetComponent<IEntity>() != null)
            {
                target.GetComponent<IEntity>().Damage(100);
                time = 0;
            }
        }
    }
    private void OnCollisionStay(Collision other) {
        if (other.transform.CompareTag("Player"))
        {
            Debug.Log("hit");
            if (time <= 1f && target.GetComponent<IEntity>() != null)
            {
                target.GetComponent<IEntity>().Damage(100);
                time = 0;
            }
        }
    }
}
