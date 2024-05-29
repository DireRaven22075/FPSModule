namespace EMSYS.FPS.ScriptableObject
{
    using UnityEngine;
    
    [CreateAssetMenu(fileName = "WEAPON", menuName = "ScriptableObject/Weapon", order = 0)]
    public class WeaponDB : ScriptableObject
    {
        public string name;
        public int maxDamage;
        public int minDamage;
        public float range;
        public float perTime;
        public GameObject prefab;
    }
}