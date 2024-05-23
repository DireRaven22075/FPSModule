namespace EMSYS.FPS.Interface
{
    public interface IEquipment
    {
        public int maxCount { get; }
        public int count { get; set; }
        public int currentCount { get; set; }
        public void Equip();
        public void UnEquip();
        public void MainUse();
        public void SubUse();
        public void Reload();
    }
}
