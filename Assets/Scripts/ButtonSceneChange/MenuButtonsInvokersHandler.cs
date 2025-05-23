using System.Collections.Generic;

namespace Invokers
{
    public class MenuButtonsInvokersHandler : InvokersHandler
    {
        protected override List<IInvoker> CollectInvokers()
        {
            return CollectInvokers<ButtonSceneChangeInvoker>();
        }
    }
}