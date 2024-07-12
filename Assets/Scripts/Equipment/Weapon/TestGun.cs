using EMSYS.FPS.Interface;
using UnityEngine;

namespace EMSYS.FPS.Equipment
{
    public class TestGun : MonoBehaviour, IWeapon
    {
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