namespace Utils.Invokers
{
    public class PauseInvokersHandler : InvokersHandler
    {
        protected override IInvoker[] CollectInvokers()
        {
            return gameObject.GetComponentsInChildren<PauseInvoker>();
        }
    }
}

