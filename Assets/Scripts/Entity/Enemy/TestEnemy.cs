using System.Collections;
using System.Collections.Generic;
using EMSYS.FPS.Interface;
using UnityEngine;

namespace EMSYS.FPS.Entity.Enemy
{
    public class TestEnemy : MonoBehaviour, IEntity
    {
        public int health { get; set; } = 100;
        public void Damage(int damage)
        {
            health -= damage;
            Debug.Log(string.Format("{0}: {1}", name, health));
            if (health <= 0)
            {
                Die();
            }
        }
        public void Die()
        {
            Destroy(gameObject);
        }
    }
}