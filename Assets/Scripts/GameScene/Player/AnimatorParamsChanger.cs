using Resources;
using UnityEngine;

namespace StateChangers
{
    public class AnimatorParamsChanger : IStateChanger
    {
        private Animator _animator;

        public AnimatorParamsChanger(Animator animator)
        {
            _animator = animator;
        }

        public void ChangeParams(PlayerState newState)
        {
            if (newState != PlayerState.Idle)
            {
                _animator.SetTrigger(newState.ToString());
            }
        }
    }
}