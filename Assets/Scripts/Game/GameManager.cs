using System;
using UnityEngine;

namespace OcarinaStudios.MathRacing.Game
{
    public class GameManager: MonoBehaviour, IGameManager
    {
        private bool _isPaused;

        public event Action OnPause;
        public event Action OnResume;

        public void Pause()
        {
            if (_isPaused) return;

            _isPaused = true;
            Time.timeScale = 0;
            OnPause?.Invoke();
        }

        public void Resume()
        {
            if (!_isPaused) return;

            _isPaused = false;
            Time.timeScale = 1;
            OnResume?.Invoke();
        }

        public bool IsPaused()
        {
            return _isPaused;
        }
    }
}