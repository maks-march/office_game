using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


namespace Invokers
{
    public class InvokersHandler : MonoBehaviour, IInvokersHandler
    {
        [SerializeField] private List<InvokersHandler> _targetInvokerHandlers;

        private IEnumerable<IInvoker> _invokers;

        private void Awake()
        {
            if (_invokers != null)
            {
                return;
            }
            BuildOwnInvokers();
            if (_targetInvokerHandlers.Count != 0)
            {
                List<IInvoker> invokers = new List<IInvoker>(_invokers);
                foreach (var handler in _targetInvokerHandlers)
                {
                    invokers.AddRange(handler.GetInvokers());
                }
                _invokers = invokers;
            }
        }
        private void BuildOwnInvokers()
        {
            _invokers = CollectInvokers();
        }

        protected List<IInvoker> CollectInvokers<T>() where T : IInvoker
        {
            var invokers = new List<IInvoker>();
            invokers.AddRange(gameObject.GetComponentsInChildren<T>());
            return invokers;
        }

        protected virtual List<IInvoker> CollectInvokers()
        {
            return CollectInvokers<IInvoker>();
        }

        public IEnumerable<IInvoker> GetInvokers()
        {
            if (_invokers == null)
            {
                Awake();
            }
            foreach (IInvoker invoker in _invokers)
            {
                if (invoker == null)
                {
                    break;
                }
                yield return invoker;
            }
        }
    }
}