using Resources;


namespace Invokers
{
    public class PlayerStateInvoker : Invoker
    {
        private PlayerState _newState = PlayerState.Idle;

        public PlayerState GetNewState { get { return _newState; } }

        public void ChangeInvokeState(PlayerState newState)
        {
            _newState = newState;
        }
    }
}