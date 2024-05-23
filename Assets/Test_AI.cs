using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using EMSYS.FPS.Interface;
public enum AIState
{
    Idle,
    Move,
    Attack,
    Find,
    Searching
}
public class Test_AI : MonoBehaviour, IEntity
{
    public int health {get; set;}
    public AIState aiState = AIState.Idle;
    [SerializeField]
    private float distance = 10;
    private float atkTime = 1;
    private float time = 0;
    private NavMeshAgent agent;
    private Transform target;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.Find("Player").transform;
    }
    public void Damage(int value)
    {
        health -= value;
        if (health <= 0)
        {
            Die();
        }
    }
    public void Die()
    {
        Destroy(this.gameObject);
    }
    private void Idle()
    {

    }

    async void Update()
    {
        switch (aiState)
        {
        }
        Ray ray = new Ray(transform.position, target.position - transform.position);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, distance))
        {
            if (hit.transform.CompareTag("Player"))
            if (hit.transform.CompareTag("Player"))
            {
                //agent.SetDestination(target.position);
                time += Time.deltaTime;
                if (time >= atkTime)
                {
                    Debug.Log("공격");
                    time = 0;
                }
            }
            else
            {
                time = 0;
            }
        }
    }
}
