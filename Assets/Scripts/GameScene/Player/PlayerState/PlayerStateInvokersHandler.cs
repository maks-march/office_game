using Invokers;
using System.Collections.Generic;

namespace GameScene
{
    public class PlayerStateInvokersHandler : InvokersHandler
    {
        protected override List<IInvoker> CollectInvokers()
        {
            return CollectInvokers<PlayerStateInvoker>();
        }
    }
}