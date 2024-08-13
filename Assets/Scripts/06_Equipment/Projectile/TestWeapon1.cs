using UnityEngine;
using EMSYS.FPS.Interface;

namespace EMSYS.FPS.Equipment
{
    public class TestWeapon1 : MonoBehaviour, IWeapon
    {
        public int magazine { get; private set; } = 30;
        public int maxMagazine { get; private set; } = 30;
        public int ammo { get; private set; } = 90;
        public int maxAmmo { get; private set; } = 90;

        public void MainStart()
        {
            Debug.Log("MainStart");
        }

        public void MainEnd()
        {
            Debug.Log("MainEnd");
        }

        public void SubStart()
        {
            Debug.Log("SubStart");
        }

        public void SubEnd()
        {
            Debug.Log("SubEnd");
        }

        public void ReloadStart()
        {
            Debug.Log("ReloadStart");
        }

        public void ReloadEnd()
        {
            Debug.Log("ReloadEnd");
        }
    }
}