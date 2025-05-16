using Resources;
using System.Collections.Generic;
using UnityEngine;


namespace Invokers
{
    public class BackgroundStarter : ChangeHandler
    {
        private IEnumerable<Animator> _animators;

        protected override void OnAwake()
        {
            _animators = GetComponentsInChildren<Animator>();
        }

        protected override void OnEvent(IInvoker invoker)
        {
            StartAnimators();
        }

        private void StartAnimators()
        {
            foreach (var animator in _animators)
            {
                animator.SetTrigger(ConstantResources.StartTriggerName);
            }
            this.enabled = false;
        }
    }
}
