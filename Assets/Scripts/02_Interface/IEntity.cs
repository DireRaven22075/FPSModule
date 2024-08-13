namespace EMSYS.FPS.Interface
{
    public interface IEntity
    {
        int Health { get; }
        int Armor { get; }
        void Damage(int value);
        void Heal(int value);
        void ArmorUp(int value);
        void Die();
    }
}