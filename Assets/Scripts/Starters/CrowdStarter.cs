using Invokers;
using UnityEngine;

namespace GameScene
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