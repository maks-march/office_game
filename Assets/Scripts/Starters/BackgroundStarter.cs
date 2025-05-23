using UnityEngine;


namespace ChangeHandlers
{
    public class BackgroundStarter : AnimatorsStarter
    {
        protected override void OnAwake()
        {
            _animators = GetComponentsInChildren<Animator>();
        }
    }
}
