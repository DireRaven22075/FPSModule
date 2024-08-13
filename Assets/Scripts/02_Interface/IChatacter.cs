using UnityEngine;
namespace EMSYS.FPS.Interface
{
    public interface ICharacter
    {
        void AnimationStart(string name);
        void AnimationEnd(string name);
    }
}