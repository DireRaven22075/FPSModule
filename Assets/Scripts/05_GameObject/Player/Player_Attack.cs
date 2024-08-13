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
        
    }
}

#if false
        private void Zoom()
        {
            if (Input.GetMouseButtonDown(1))
            {
                StartCoroutine(ZoomIn());
            }
            else if (Input.GetMouseButtonUp(1))
            {
                camera.fieldOfView = 60;
            }
        }
        private IEnumerator ZoomIn()
        {
            for (int i = 60; i > 30; i--)
            {
                camera.fieldOfView = i;
                yield return new WaitForSeconds(0.01f);
            }
        }
        private void Attack()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                weaponIndex = 1;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                weaponIndex = 2;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                weaponIndex = 3;
            }
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
            if (weapons[0].loadedAmmo > 0)
            {
                weapons[0].loadedAmmo--;

                if (Physics.Raycast(camera.transform.position, camera.transform.forward, out RaycastHit hit))
                {
                    if (hit.transform.GetComponent<IEntity>() != null)
                    {
                        hit.transform.GetComponent<IEntity>().Damage(weapons[0].damage);
                    }
                }
            }
            else
            {
                weapons[0].ReloadAmmo();
                CancelInvoke("Weapon");
            }
        }
        private void WeaponATKUp()
        {
            CancelInvoke("Weapon");
        }
        private void ProjectileATK()
        {
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
#endif