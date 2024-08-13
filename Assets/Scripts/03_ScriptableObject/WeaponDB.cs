namespace EMSYS.FPS.ScriptableObject
{
    using UnityEngine;
    
    [CreateAssetMenu(fileName = "WEAPON", menuName = "ScriptableObject/Weapon", order = 0)]
    public class WeaponDB : ScriptableObject
    {
        public string name;

        public int magazine;

        public int[] damage;
        public int[] range;
        public int bpm;
        public int accuracy;
        public GameObject prefab;
    }
}