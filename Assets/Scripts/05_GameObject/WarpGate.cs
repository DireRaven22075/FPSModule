using System.Collections;
using System.Collections.Generic;
using EMSYS.FPS.Interface;
using UnityEngine;

namespace EMSYS.FPS.Entity.Object
{
    [RequireComponent(typeof(MeshCollider))]
    public class WarpGate : MonoBehaviour
    {
        [SerializeField]
        private Transform destination;
        private void OnTriggerEnter(Collider other)
        {
            if (other.GetComponent<IEntity>() != null)
            {
                other.transform.position = destination.position;
            }
        }
    }
}
