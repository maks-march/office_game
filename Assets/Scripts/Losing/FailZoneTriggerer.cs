using Invokers;
using UnityEngine;
using Resources;


namespace Losing
{
    [RequireComponent (typeof (Collider2D))]
    public class FailZoneTriggerer : MonoBehaviour
    {
        [SerializeField] private FailInvoker _failInvoker;

        private Tags _losingFilter;

        private void Awake()
        {
            _losingFilter = Tags.Player;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (!string.IsNullOrEmpty(_losingFilter.ToString()) && !collision.CompareTag(_losingFilter.ToString()))
                return;

            _failInvoker.Invoke();
        }
    }
}