using System.Collections.Generic;
using UnityEngine;

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

