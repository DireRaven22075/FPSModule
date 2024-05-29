using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EMSYS.FPS.UI
{
    public class CrosshairUI : MonoBehaviour
    {
        public float radius;
        public RectTransform[] crosshairs = new RectTransform[4];
        private void Start()
        {
            for (int i = 0 ; i < 4; i++) {
                crosshairs[i] = transform.GetChild(i).GetComponent<RectTransform>();
            }
        }
    }
}