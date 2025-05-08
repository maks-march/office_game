using System.Collections.Generic;


namespace Invokers
{
    public class PauseInvokersHandler : InvokersHandler
    {
        protected override List<IInvoker> CollectInvokers()
        {
            return CollectInvokers<PauseInvoker>();
        }
    }
}

