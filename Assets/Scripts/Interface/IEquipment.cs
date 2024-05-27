namespace EMSYS.FPS.Interface
{
    public interface IEquipment
    {
        public int maxCount { get; }
        public int count { get; set; }
        public int currentCount { get; set; }
        public void Equip(IPlayer player);
        public void UnEquip(IPlayer player);
        public void MainUse(IPlayer player);
        public void SubUse(IPlayer player);
        public void Reload(IPlayer player);
    }
}
