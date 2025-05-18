using Resources;


namespace Invokers
{
    public class JumpInputInvoker : MoveInputInvoker 
    {
        protected override void SetupPlayerState()
        {
            _newPlayerState = PlayerState.Jump;
        }

        private void OnEnable()
        {
            _actionsInvoker.Player.Enable();
            _actionsInvoker.Player.Jump.performed += ctx => Invoke();
        }

        private void OnDisable()
        {
            _actionsInvoker.Player.Jump.performed -= ctx => Invoke();
            _actionsInvoker.Player.Disable();
        }
    }
}