using UnityEngine;

namespace EMSYS.FPS
{
    [CreateAssetMenu(fileName = "WeaponData", menuName = "ScriptableObject/FPS/Weapon", order = 0)]
    public class WeaponDB : ScriptableObject
    {
        public string name;
        
    }
}