using System.Collections;
using System.Collections.Generic;
using EMSYS.FPS.Entity.Projectile;
using UnityEngine;

namespace EMSYS.FPS.Entity
{
    public partial class Player : MonoBehaviour
    {
        void Start()
        {
            camera = GetComponentInChildren<Camera>();
            rigid = GetComponent<Rigidbody>();
            controller = GetComponent<CharacterController>();
            isGround = true;
        }
        [SerializeField]
        private GameObject grenade;
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Instantiate<GameObject>(grenade, camera.transform.position, camera.transform.rotation);
            }
            if (isGround)
            {
                Rotate();
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    Jump();
                }
            }
        }
        private void FixedUpdate()
        {
            if (isGround)
            {
                Move();
            }
        }
    }
}
