using System.Runtime.InteropServices;
using UnityEngine;
namespace EMSYS.FPS.Entity
{
    public partial class Player : MonoBehaviour
    {
        protected void Move()
        {
            if (Input.GetAxis("Vertical") == 0 && Input.GetAxis("Horizontal") == 0)
            {
                rigid.velocity = new Vector3(0, rigid.velocity.y, 0);
                return;
            }
            Vector3 direction = new Vector3();
            direction += transform.forward * Input.GetAxis("Vertical");
            direction += transform.right * Input.GetAxis("Horizontal");
            direction.Normalize();
            direction *= 10;
            direction.y = rigid.velocity.y;
            rigid.velocity = direction;
        }
        protected void Jump()
        {
            rigid.AddForce(Vector3.up * 10, ForceMode.Impulse);
            isGround = false;
        }
        protected void Rotate()
        {
            float x = Input.GetAxis("Mouse X");
            float y = Input.GetAxis("Mouse Y");

            yRotation -= y * Constants.Physics.sensivity;
            yRotation = Mathf.Clamp(yRotation, -90, 90);
            camera.transform.localEulerAngles = new Vector3(yRotation, 0, 0);

            transform.localEulerAngles += new Vector3(0, x * Constants.Physics.sensivity, 0);
        }
        private void CheckGround()
        {
            if (Physics.Raycast(transform.position, Vector3.down, 1.1f))
            {
                isGround = true;
            }
        }
    }
}