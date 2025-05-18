using UnityEngine;


namespace Invokers
{
    public class BackgroundStarter : AnimatorsStarter
    {
        protected override void OnAwake()
        {
            _animators = GetComponentsInChildren<Animator>();
        }
    }
}
