using Resources;
using System.Collections.Generic;
using UnityEngine;
using Invokers;


namespace ChangeHandlers
{
    public class AnimatorsStarter : ChangeHandler
    {
        protected IEnumerable<Animator> _animators;

        protected override void OnAwake()
        {
            _animators = GetComponents<Animator>();
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
