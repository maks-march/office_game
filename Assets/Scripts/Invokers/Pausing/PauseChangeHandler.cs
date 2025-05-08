using UnityEngine;
using Pausing;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

namespace Invokers
{
    [RequireComponent(typeof(InputPauseInvoker))]
    public class PauseChangeHandler : ChangeHandler
    {
        private List<IPausable> _pausableElements;

        private GamePauser _pauser;
        private bool _isGameRunning = true;

        public GamePauser GetGamePauser {  get => _pauser; }


        public bool IsPaused { get => Time.timeScale == 0f; }

        protected override void Awake()
        {
            base.Awake();

            _pausableElements = FindAllPausable();

            _pauser = new GamePauser();
        }

        private List<IPausable> FindAllPausable()
        {
            bool includeInactive = true;
            var pausable = new List<IPausable>();
            var rootObjects = SceneManager.GetActiveScene().GetRootGameObjects();

            foreach (var root in rootObjects)
            {
                pausable.AddRange(root.GetComponentsInChildren<IPausable>(includeInactive));
            }
            return pausable;
        }

        public void StopGame()
        {
            _isGameRunning = false;
            _pauser.TogglePause(true);
        }

        private void ResumeGame()
        {
            _isGameRunning = true;
        }

        private void Restart(PauseInvoker invoker)
        {
            if (invoker.IsGameRestarter)
            {
                ResumeGame();
            }
        }

        protected override void OnEvent(IInvoker invoker)
        {
            Restart((PauseInvoker)invoker);

            if (_isGameRunning == false)
            {
                return;
            }

            TogglePausable();

        }

        private void TogglePausable()
        {
            bool newPauseState = IsPaused == false;

            foreach (var pausableElement in _pausableElements)
            {
                pausableElement.TogglePause(newPauseState);
            }
            _pauser.TogglePause(newPauseState);
        }
    }
}