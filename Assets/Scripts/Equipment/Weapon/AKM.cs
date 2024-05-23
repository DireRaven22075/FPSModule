using UnityEngine;
using EMSYS.FPS.Interface;
using JetBrains.Annotations;
namespace EMSYS.FPS.Equipment
{
    public class AKM : IEquipment
    {
        public int maxCount { get; }
        public int count { get; set; }
        public int currentCount { get; set; }
        public void Equip()
        {

        }
        public void UnEquip()
        {

        }
        public void MainUse()
        {
        }
        public void SubUse()
        {

        }
        public void Reload()
        {

        }
    }
}