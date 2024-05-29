using System.Collections;
using System.Collections.Generic;
using EMSYS.FPS.ScriptableObject;
using UnityEngine;

namespace EMSYS.FPS.Entity
{
    public partial class Player : MonoBehaviour
    {
        #region components
        protected Camera camera;
        protected Rigidbody rigid;
        protected CharacterController controller;
        protected AudioSource audio;
        #endregion
        #region movementVariables
        public bool isGround { get; private set; }
        private float yRotation = 0;
        #endregion
        #region attacks
        [SerializeField]
        public WeaponData[] weapons = new WeaponData[3];
        public int weaponIndex { get; private set; } = 1;
        #endregion
    }
}
