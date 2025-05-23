using Invokers;
using Resources;
using UnityEngine;


namespace Obstacles
{
    public class ReturnObstacle : MonoBehaviour
    {
        [SerializeField] private Tags _filterTag;
        [SerializeField] private bool _isScoring = false;

        private ScoreInvoker _scoreInvoker;

        private void Awake()
        {
            if (_isScoring)
            {
                _scoreInvoker = GetComponent<ScoreInvoker>();
            }
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (!string.IsNullOrEmpty(_filterTag.ToString()) && !other.CompareTag(_filterTag.ToString()))
                return;

            if (_isScoring)
            {
                _scoreInvoker.Invoke();
            }

            other.gameObject.SetActive(false);
        }
    }
}
