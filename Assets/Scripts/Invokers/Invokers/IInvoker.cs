using System;


namespace Invokers
{
    public interface IInvoker
    {
        public event Action<IInvoker> Event;
        public void Invoke();
    }
}