namespace EMSYS.FPS.Interface
{
    /// <summary>
    /// 엔티티 (생명체용 인터페이스)
    /// </summary>
    public interface IEntity
    {
        int health { get; set; }
        void Damage(int value);
        void Die();
    }
}