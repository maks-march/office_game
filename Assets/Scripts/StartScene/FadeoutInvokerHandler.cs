using System.Collections.Generic;


namespace Invokers
{
    public class FadeoutInvokerHandler : InvokersHandler
    {
        protected override List<IInvoker> CollectInvokers()
        {
            return CollectInvokers<FadeoutEndsInvoker>();
        }
    }
}

