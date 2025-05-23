using System.Collections.Generic;

namespace Invokers
{
    public class ScoreInvokersHandler : InvokersHandler
    {
        protected override List<IInvoker> CollectInvokers()
        {
            return CollectInvokers<ScoreInvoker>();
        }
    }
}

