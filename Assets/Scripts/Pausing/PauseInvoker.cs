using UnityEngine;

namespace Invokers
{
    public class PauseInvoker : Invoker 
    {
        [SerializeField] private bool _isGameRestarter = false;

        public virtual bool IsGameRestarter { get => _isGameRestarter; }
    }
}
