using UnityEngine;


namespace GameScene
{
    public class FailTriggerer : MonoBehaviour
    {
        private string _losingFilter;

        private void Awake()
        {
            _losingFilter = "Player";
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (!string.IsNullOrEmpty(_losingFilter) && !other.CompareTag(_losingFilter))
                return;

            other.gameObject.GetComponent<MovingOnEvents>().FailTriggered();
        }
    }
}