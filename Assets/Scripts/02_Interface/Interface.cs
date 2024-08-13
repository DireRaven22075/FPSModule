namespace FPS
{
    public interface IEntity
    {
        int Health { get; }
        int Armor { get; }
        void Damage(int value);
        void Heal(int value);
        void EquipArmor(int value);
        void RemoveArmor();
    }
    public interface ICharacter : IEntity
    {
        int Team { get; }
        Weapon[] slots { get; }
        void EquipWeapon(Weapon weapon, int slot);
        void Skill1();
        void Skill2();
        void Overpower();
    }
    public class Weapon
    {
        public string name;
    }
}