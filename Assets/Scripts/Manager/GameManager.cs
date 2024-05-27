using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace EMSYS.FPS.Manager
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }
        private void Awake()
        {
            if (Instance == null)
                Instance = this;
            else
                Destroy(gameObject);
        }
        public void GameOver()
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
