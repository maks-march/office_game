using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;


namespace Utils.Invokers
{
    public class InvokersHandler : MonoBehaviour, IInvokersHandler
    {
        [SerializeField] private List<InvokersHandler> _targetInvokerHandlers;

        private IEnumerable<IInvoker> _invokers;

        private void Awake()
        {
            _invokers = CollectInvokers();
        }

        private void OnEnable()
        {
            if (_targetInvokerHandlers.Count != 0)
            {
                List<IInvoker> invokers = new List<IInvoker>();
                foreach (var handler in _targetInvokerHandlers)
                {
                    invokers.AddRange(handler.GetInvokers());
                }
                _invokers = invokers;
            }
        }

        protected virtual IInvoker[] CollectInvokers()
        {
            return gameObject.GetComponentsInChildren<IInvoker>();
        }

        public IEnumerable<IInvoker> GetInvokers()
        {
            if (_invokers == null)
            {
                _invokers = CollectInvokers();
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