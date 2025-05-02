namespace Utils.Invokers
{
    public class FadeoutInvokerHandler : InvokersHandler
    {
        protected override IInvoker[] CollectInvokers()
        {
            return gameObject.GetComponentsInChildren<FadeoutEndsInvoker>();
        }
    }
}

