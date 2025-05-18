using System.Collections.Generic;


namespace Invokers
{
    public interface IInvokersHandler
    {
        public IEnumerable<IInvoker> GetInvokers();
    }
}