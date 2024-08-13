using UnityEngine;
namespace EMSYS.FPS.Interface
{
    public interface ICharacter : IEntity
    {
        int Health { get; }
        int Armor { get; }
        void Heal(int value);
        void ArmorUp(int value);
    }
}