using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Manager
{
    public class GameManager : MonoBehaviour
    {
        private bool _gameHasEnded = false;
        public float restartDelay = 1f;
        public static int levelNumber;

        // public GameObject completeLevelUI;
        public static GameManager Instance { get; private set; }
        public event Action OnGameStarted;
        public event Action OnLevelEnded;
    
    
        public void CompleteLevel()
        {   
            OnLevelEnded?.Invoke();
            // completeLevelUI.SetActive(true);
        }

        // ReSharper disable Unity.PerformanceAnalysis
        public void EndGame()
        {
            if (_gameHasEnded == false)
            {
                _gameHasEnded = true;
                Debug.Log("GAME OVER");
                Invoke(nameof(Restart), restartDelay);
            }
        }

        private void Awake()
        {
            Instance = this;
            OnGameStarted?.Invoke();
            // SaveManager.Instance.Load();
        }

        void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}