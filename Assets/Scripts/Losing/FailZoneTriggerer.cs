using Invokers;
using UnityEngine;


namespace Losing
{
    [RequireComponent (typeof (Collider2D))]
    public class FailZoneTriggerer : MonoBehaviour
    {
        [SerializeField] private FailInvoker _failInvoker;

        private string _losingFilter;

        private void Awake()
        {
            _losingFilter = "Player";
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (!string.IsNullOrEmpty(_losingFilter) && !collision.CompareTag(_losingFilter))
                return;

            _failInvoker.Invoke();
        }
    }
}