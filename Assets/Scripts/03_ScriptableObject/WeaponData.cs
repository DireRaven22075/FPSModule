using UnityEngine;

namespace EMSYS.FPS
{
    public enum WeaponType
    {
        Pistol,
        ShotGun,
        Rifle,
        Sniper,
        
    }
    [CreateAssetMenu(fileName = "Weapon", menuName = "ScriptableObject/Weapon", order = 0)]
    public class WeaponDB : ScriptableObject
    {
        public string weaponName;
        public int magazine;
        public int[] damages;
        public int[] ranges;
        public int bpm;
        public GameObject prefab;
    }
}