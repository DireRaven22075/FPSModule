namespace EMSYS.FPS.ScriptableObject
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

    }
}