using UnityEngine;

namespace GameScene
{
    [RequireComponent (typeof (LoseInvoker))]
    [RequireComponent (typeof (Collider2D))]
    public class LozeZoneTriggerer : MonoBehaviour
    {
        private string _losingFilter;

        private void Awake()
        {
            _losingFilter = "Player";
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (!string.IsNullOrEmpty(_losingFilter) && !collision.CompareTag(_losingFilter))
                return;

            gameObject.GetComponent<LoseInvoker>().Invoke();
        }
    }
}