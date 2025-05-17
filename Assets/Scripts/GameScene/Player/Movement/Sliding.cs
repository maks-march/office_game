using Resources;
using System.Collections;
using UnityEngine;


namespace GameScene
{
    [RequireComponent(typeof(Collider2D))]
    public class Sliding : MonoBehaviour, IMovePerformer
    {
        [SerializeField] private CapsuleCollider2D _collider;
        [SerializeField] private float _duration = 0.5f;

        private float _baseOffset;
        private float _baseHeight;
        private bool _isPlaying = false;

        public PlayerState State { get => PlayerState.Sliding; }
        public bool IsPlaying { get { return _isPlaying; } }

        private void Awake()
        {
            _baseOffset = _collider.offset.y;
            _baseHeight = _collider.size.y;
        }

        public void Stop()
        {
            _isPlaying = false;
            StopCoroutine(Movement());
            End();
        }

        public void PerformMovement()
        {
            if (_isPlaying == false)
            {
                _isPlaying = true;
                StartCoroutine(Movement());
            }
        }
        private IEnumerator Movement()
        {
            float newOffset = _baseOffset / 3;
            float newHeight = _baseHeight / 3;
            _collider.offset = new Vector2(_collider.offset.x, newOffset);
            _collider.size = new Vector2(_collider.size.x, newHeight);
            float time = 0f;
            while (time < 1f)
            {
                time += Time.deltaTime / _duration;
                yield return null;
            }
            End();

            _isPlaying = false;
        }

        private void End()
        {
            _collider.offset = new Vector2(_collider.offset.x, _baseOffset);
            _collider.size = new Vector2(_collider.size.x, _baseHeight);
        }
    }
}