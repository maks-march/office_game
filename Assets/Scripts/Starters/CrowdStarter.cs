using Invokers;
using UnityEngine;


namespace ChangeHandlers
{
    public class CrowdStarter : AnimatorsStarter
    {
        [SerializeField] private InvokersHandler _animatorInvokersHandler;

        protected override IInvokersHandler GetInvokerHandler()
        {
            return _animatorInvokersHandler;
        }
    }
}