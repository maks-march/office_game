using UnityEngine;
using Utils.Invokers;
using Utils.StateChangers;


namespace Utils.ChangeHandlers
{
    [RequireComponent(typeof(InvokersHandler))]
    [RequireComponent(typeof(PauseInvoker))]
    public class RestartChangeHandler : ChangeHandler
    {
        private RestartScene GetRestarter { get => (RestartScene)_changer; }

        protected override void Awake()
        {
            base.Awake();
            SetupRestarter();
        }

        private void SetupRestarter()
        {
            PauseInvoker pauseInvoker = gameObject.GetComponent<PauseInvoker>();
            _changer = new RestartScene(pauseInvoker);
        }

        protected override void OnEvent(IInvoker invoker)
        {
            GetRestarter.Restart();
        }
    }
}


