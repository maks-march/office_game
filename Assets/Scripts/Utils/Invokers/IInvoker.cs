using System;


namespace Utils.Invokers
{
    public interface IInvoker
    {
        public event Action<IInvoker> Event;
        public void Invoke();
    }
}