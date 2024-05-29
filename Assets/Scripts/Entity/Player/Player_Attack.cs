using System.Collections;
using System.Collections.Generic;
using EMSYS.FPS.Entity.Projectile;
using UnityEngine;
using UnityEngine.Assertions.Must;
using EMSYS.FPS.Interface;
using EMSYS.FPS.ScriptableObject;

namespace EMSYS.FPS.Entity
{
    public partial class Player : MonoBehaviour
    {
        private void Attack()
        {
            if (Input.GetMouseButtonDown(0))
            {
                switch (weaponIndex)
                {
                    case 1: WeaponATK(); return;
                    case 2: ProjectileATK(); return;
                    case 3: MeleeATK(); return;
                }
            }
            else if (Input.GetMouseButtonUp(0))
            {
                switch (weaponIndex)
                {
                    case 1: WeaponATKUp(); return;
                    case 3: MeleeATKUp(); return;
                }
            }
        }
        private void WeaponATK()
        {
            InvokeRepeating("Weapon", 0, weapons[0].perTime);
        }
        private void Weapon()
        {
            if (Physics.Raycast(camera.transform.position, camera.transform.forward, out RaycastHit hit))
            {
                if (hit.transform.GetComponent<IEntity>() != null)
                {
                    hit.transform.GetComponent<IEntity>().Damage(weapons[0].damage);
                }
            }
        }
        private void WeaponATKUp()
        {
            CancelInvoke("Weapon");
        }
        private void ProjectileATK()
        {
            Instantiate<GameObject>(grenade, camera.transform.position, camera.transform.rotation);
        }
        private void MeleeATK()
        {
            InvokeRepeating("Melee", 0, weapons[2].perTime);
        }
        private void Melee()
        {
            if (Physics.Raycast(camera.transform.position, camera.transform.forward, out RaycastHit hit, weapons[2].range))
            {
                if (hit.transform.GetComponent<IEntity>() != null)
                {
                    hit.transform.GetComponent<IEntity>().Damage(weapons[2].damage);
                }
            }
        }
        private void MeleeATKUp()
        {
            CancelInvoke("Melee");
        }
    }
}
