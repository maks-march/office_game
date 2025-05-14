using Resources;


namespace Invokers
{
    public class MoveInputInvoker : Invoker
    {
        protected PlayerState _newPlayerState;
        protected PlayerActionsInvoker _actionsInvoker;

        private void Awake()
        {
            _actionsInvoker = new PlayerActionsInvoker();
            SetupPlayerState();
        }

        protected virtual void SetupPlayerState()
        {
            _newPlayerState = PlayerState.Idle;
        }

        public PlayerState NewPlayerState { get => _newPlayerState; }
    }
}