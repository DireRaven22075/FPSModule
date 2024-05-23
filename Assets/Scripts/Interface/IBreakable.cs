namespace EMSYS.FPS.Interface
{
    /// <summary>
    /// 파괴가능한 오브젝트
    /// </summary>
    public interface IBreakable
    {
        int health { get; set; }
        void Damage(int value);
        void Break();
    }
}