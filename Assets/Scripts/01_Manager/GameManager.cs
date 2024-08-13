using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace EMSYS.FPS.Manager
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance
        {
            get
            {
                if (Instance == null)
                {
                    if ((Instance = FindObjectOfType<GameManager>()) == null)
                    {
                        GameObject obj = new GameObject("GameManager");
                        Instance = obj.AddComponent<GameManager>();
                        DontDestroyOnLoad(obj);
                    }
                }
                return Instance;
            }
            private set 
            {
                Instance = value;
            }
        }
        private void Awake()
        {
            if (Instance == null)
                Instance = this;
            else
                Destroy(gameObject);
        }
    }
}
