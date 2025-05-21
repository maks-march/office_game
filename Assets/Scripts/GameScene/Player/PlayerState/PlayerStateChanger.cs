using Invokers;
using Resources;


namespace GameScene
{
    public class PlayerStateChanger : ChangeHandler
    {
        private PlayerState _currentState;

        public PlayerState GetPlayerState { get => _currentState; }

        public void ChangeState(PlayerState newState)
        {
            _currentState = newState;
        }

        protected override void OnEvent(IInvoker invoker)
        {
            PlayerStateInvoker playerStateInvoker = (PlayerStateInvoker)invoker;

            PlayerState newState = playerStateInvoker.GetNewState;

            ChangeState(newState);
        }
    }
}