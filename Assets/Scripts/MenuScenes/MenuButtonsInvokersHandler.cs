namespace Utils.Invokers
{
    public class MenuButtonsInvokersHandler : InvokersHandler
    {
        protected override IInvoker[] CollectInvokers()
        {
            return gameObject.GetComponentsInChildren<ButtonSceneChangeInvoker>();
        }
    }
}