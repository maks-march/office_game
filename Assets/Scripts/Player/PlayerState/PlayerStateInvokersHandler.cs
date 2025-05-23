using System.Collections.Generic;


namespace Invokers
{
    public class PlayerStateInvokersHandler : InvokersHandler
    {
        protected override List<IInvoker> CollectInvokers()
        {
            return CollectInvokers<PlayerStateInvoker>();
        }
    }
}