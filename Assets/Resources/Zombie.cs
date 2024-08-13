using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using EMSYS.FPS.Interface;
public class Zombie : MonoBehaviour, IEntity
{
    public int Health { get; private set; } = 100;
    public int Armor { get; private set; } = 0;

    public void Damage(int value)
    {
        if (Armor > 0)
        {
            Armor -= value;
            if (Armor < 0)
            {
                Health += Armor;
                Armor = 0;
            }
        }
        else
        {
            Health -= value;
        }
    }
    public void Die()
    {
        Destroy(this.gameObject);
    }
    public void Heal(int value)
    {
        Health = Mathf.Clamp(value + Health, 0, 100);
    }
    public void ArmorUp(int value)
    {
        Armor = Mathf.Clamp(value + Armor, 0, 50);
    }

    float time = 0;
    public Transform target;
    public NavMeshAgent agent;
    void OnEnable()
    {
        if (!agent)
        {
            agent = this.GetComponent<NavMeshAgent>();
        }
        Health = 100;
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
