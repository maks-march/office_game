using System.Collections.Generic;


namespace Utils.Invokers
{
    public interface IInvokersHandler
    {
        public IEnumerable<IInvoker> GetInvokers();
    }
}