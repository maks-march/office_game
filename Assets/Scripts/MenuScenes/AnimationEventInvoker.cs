using System;
using UnityEngine;

public class AnimationEventInvoker : MonoBehaviour
{
    public event Action AnimationEnds;
    
    protected void TriggerAnimationEnds()
    {
        AnimationEnds?.Invoke();
    }
}
