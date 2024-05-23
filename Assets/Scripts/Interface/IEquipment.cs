namespace EMSYS.FPS.Interface
{
    public interface IEquipment
    {
        int maxCount { get; }
        int count { get; set; }
        int currentCount { get; set; }
        void Equip();
        void UnEquip();
        void MainUse();
        void SubUse();
        void Reload();
    }
}
