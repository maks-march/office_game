using UnityEngine;
using StateChangers;
using Invokers;


namespace ChangeHandlers
{
    [RequireComponent(typeof(InvokersHandler))]
    public class ChangeHandler : MonoBehaviour
    {
        protected IInvokersHandler _invokersHandler;
        protected IStateChanger _changer;

        protected bool _isSubscribed;


        protected IInvokersHandler GetInvokerHandler<T>() where T : IInvokersHandler
        {
            return gameObject.GetComponent<T>();
        }
        protected virtual IInvokersHandler GetInvokerHandler()
        {
            return GetInvokerHandler<IInvokersHandler>();
        }

        private void Awake()
        {
            _isSubscribed = false;
            _invokersHandler = GetInvokerHandler();
            OnAwake();
        }

        protected virtual void OnAwake() 
        {
            
        }

        private void OnEnable()
        {
            ChangeSubscription();
        }

        private void OnDisable()
        {
            ChangeSubscription();
        }

        private void ChangeSubscription()
        {
            foreach (IInvoker invoker in _invokersHandler.GetInvokers())
            {
                if (_isSubscribed == false)
                {
                    invoker.Event += OnEvent;
                }
                else
                {
                    invoker.Event -= OnEvent;
                }
            }
            _isSubscribed = !_isSubscribed;
        }

        protected virtual void OnEvent(IInvoker invoker)
        {

        }
    }
}
