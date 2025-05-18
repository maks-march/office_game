using Resources;


namespace Invokers
{
    public class SlidingInputInvoker : MoveInputInvoker 
    {
        protected override void SetupPlayerState()
        {
            _newPlayerState = PlayerState.Sliding;
        }

        private void OnEnable()
        {
            _actionsInvoker.Player.Enable();
            _actionsInvoker.Player.Roll.performed += ctx => Invoke();
        }

        private void OnDisable()
        {
            _actionsInvoker.Player.Roll.performed -= ctx => Invoke();
            _actionsInvoker.Player.Disable();
        }
    }
}