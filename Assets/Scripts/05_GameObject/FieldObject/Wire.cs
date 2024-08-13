using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using EMSYS.FPS.Interface;

namespace EMSYS.FPS.Object
{
    public class Wire : MonoBehaviour, IObject
    {
        public void Interact(IEntity target)
        {
            if (target is ICharacter)
            {
                ICharacter character = target as ICharacter;
                character.Heal(10);
            }
        }
    }
}