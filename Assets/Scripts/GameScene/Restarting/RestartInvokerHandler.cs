namespace Utils.Invokers
{
    public class RestartInvokerHandler : InvokersHandler
    {
        protected override IInvoker[] CollectInvokers()
        {
            return gameObject.GetComponentsInChildren<RestartInvoker>();
        }
    }
}