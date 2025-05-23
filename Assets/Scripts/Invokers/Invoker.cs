using System;
using UnityEngine;


namespace Invokers
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
