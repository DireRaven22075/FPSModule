namespace EMSYS.FPS.Interface
{
    /// <summary>
    /// 플레이어
    /// </summary>
    public interface IPlayer
    {
        /// <summary>
        /// 플레이어의 장비
        /// 0. 주무기
        /// 1. 보조무기
        /// 2. 투척무기
        /// 3. 근접무기
        /// </summary>
        IEquipment[] equipments { get; set; }
        void SupplyAmmo(float percent = 1f);
        void SupplyHealth(int value);

    }
}