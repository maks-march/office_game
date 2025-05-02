namespace Utils.Invokers
{
    public class PauseInvoker : Invoker
    {
        private PlayerActionsInvoker controls;

        private void Awake()
        {
            controls = new PlayerActionsInvoker();
        }

        private void OnEnable()
        {
            controls.UI.Enable();
            controls.UI.PauseAction.performed += ctx => Invoke();
        }

        private void OnDisable()
        {
            controls.UI.PauseAction.performed -= ctx => Invoke();
            controls.UI.Disable();
        }
    }
}
