using System.Collections.Generic;


namespace Invokers
{
    public class LoseInvokersHandler : InvokersHandler
    {
        protected override List<IInvoker> CollectInvokers()
        {
            return CollectInvokers<LoseInvoker>();
        }
    }
}

