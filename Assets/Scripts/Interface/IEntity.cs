namespace EMSYS.FPS.Interface
{
    public interface IEntity
    {
        int health { get; set; }
        void Damage(int value);
        void Die();
    }
}