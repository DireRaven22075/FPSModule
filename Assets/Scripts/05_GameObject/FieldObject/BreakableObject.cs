using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using EMSYS.FPS.Interface;

namespace EMSYS.FPS.Object
{
    //피해를 받으면 파괴되는 오브젝트 (상자, 벽 등)
    public class BreakableObject : MonoBehaviour, IEntity
    {
        [SerializeField]
        private int health = 50;
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

        }
    }
}