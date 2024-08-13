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
            Cursor.lockState = CursorLockMode.Locked;
            
        }
        void Update()
        {
            Attack();
            Rotate();
            if (isGround && Input.GetKeyDown(KeyCode.Space))
            {
                Jump();
            }
        }
        private void FixedUpdate()
        {
            CheckGround();
            if (isGround)
            {
                Move();
            }
        }
    }
}
