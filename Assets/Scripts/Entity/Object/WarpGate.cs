using System.Collections;
using System.Collections.Generic;
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
            if (other.gameObject.layer == LayerMask.NameToLayer("Team.Red") || other.gameObject.layer == LayerMask.NameToLayer("Team.Blue"))
            {
                other.transform.position = destination.position;
            }
        }
    }
}
