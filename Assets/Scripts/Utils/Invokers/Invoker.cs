using System;
using UnityEditor.Timeline.Actions;
using UnityEngine;

namespace Utils.Invokers
{
    public class Invoker : MonoBehaviour, IInvoker
    {
        public event Action<IInvoker> Event;

        public virtual void Invoke()
        {
            Event?.Invoke(this);
        }
    }
}
