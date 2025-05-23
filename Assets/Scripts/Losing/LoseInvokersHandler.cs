using Invokers;
using System.Collections.Generic;


namespace GameScene
{
    public class LoseInvokersHandler : InvokersHandler
    {
        protected override List<IInvoker> CollectInvokers()
        {
            return CollectInvokers<LoseInvoker>();
        }
    }
}

