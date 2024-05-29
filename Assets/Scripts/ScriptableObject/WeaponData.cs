namespace EMSYS.FPS
{
    using UnityEngine;
    
    [CreateAssetMenu(fileName = "WeaponData", menuName = "WeaponData", order = 0)]
    public class WeaponData : ScriptableObject
    {
        public string name;
        public int damage;
        public float range;
        public float perTime;
        public GameObject prefab;
        public AudioClip fireSound;

        [SerializeField]
        private int reloadAmmo;
        public int loadedAmmo;
        public int ammo;
        public int maxAmmo;

        public void SupplyAmmo(float percent = 1f)
        {
            ammo = (int)(maxAmmo * percent);
        }
        public void ReloadAmmo()
        {
            if (ammo > 0)
            {
                int needAmmo = reloadAmmo - loadedAmmo;
                if (ammo >= needAmmo)
                {
                    loadedAmmo += needAmmo;
                    ammo -= needAmmo;
                }
                else
                {
                    loadedAmmo += ammo;
                    ammo = 0;
                }
            }
        }
    }
}