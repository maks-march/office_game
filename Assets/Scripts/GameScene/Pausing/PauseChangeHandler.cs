using UnityEngine;
using Utils.ChangeHandlers;
using Utils.Invokers;

namespace GameScene.Pausing
{
    public class PauseChangeHandler : ChangeHandler
    {
        private IPausable[] _pausableElements;

        private GamePauser _pauser;

        public GamePauser GetGamePauser {  get => _pauser; }
        public bool GetIsPaused { get => Time.timeScale == 1f; }

        protected override void Awake()
        {
            base.Awake();

            bool includeInactive = true;
            _pausableElements = gameObject.transform.root.GetComponentsInChildren<IPausable>(includeInactive);

            _pauser = new GamePauser();
        }

        protected override void OnEvent(IInvoker invoker)
        {
            bool currentPauseState = GetIsPaused == false;

            foreach (var pausableElement in _pausableElements)
            {
                pausableElement.TogglePause(currentPauseState);
            }
            _pauser.TogglePause(currentPauseState);
        }
    }
}