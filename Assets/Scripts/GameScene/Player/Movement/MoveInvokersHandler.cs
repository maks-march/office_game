using System.Collections.Generic;

namespace Invokers
{
    public class MoveInvokersHandler : InvokersHandler
    {
        protected override List<IInvoker> CollectInvokers()
        {
            return CollectInvokers<MoveInputInvoker>();
        }

    }
}