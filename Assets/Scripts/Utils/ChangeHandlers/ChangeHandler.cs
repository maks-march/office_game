using UnityEngine;
using Utils.Invokers;
using Utils.StateChangers;


namespace Utils.ChangeHandlers
{
    [RequireComponent(typeof(InvokersHandler))]
    public class ChangeHandler : MonoBehaviour
    {
        protected IInvokersHandler _invokersHandler;
        protected IStateChanger _changer;

        protected bool _isSubscribed;


        protected void BuildChangeHandler()
        {
            _isSubscribed = false;
            _invokersHandler = gameObject.GetComponent<IInvokersHandler>();
        }

        protected virtual void Awake()
        {
            BuildChangeHandler();
        }

        private void Start()
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
