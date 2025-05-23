using Resources;
using System.Collections;
using UnityEngine;


namespace GameScene
{
    [RequireComponent(typeof(Collider2D))]
    [RequireComponent(typeof(PlayerStateInvoker))]
    public class Sliding : MonoBehaviour, IMovePerformer
    {
        [SerializeField] private CapsuleCollider2D _collider;
        [SerializeField] private float _duration = 0.5f;

        private PlayerStateInvoker _playerStateInvoker;
        private float _baseOffset;
        private float _baseHeight;
        private bool _isPlaying = false;

        public PlayerState State { get => PlayerState.Sliding; }
        public bool IsPlaying { get { return _isPlaying; } }

        private void Awake()
        {
            _baseOffset = _collider.offset.y;
            _baseHeight = _collider.size.y;
            _playerStateInvoker = GetComponent<PlayerStateInvoker>();
        }

        public void Stop()
        {
            _isPlaying = false;
            ChangeState(PlayerState.Run);
            StopCoroutine(Movement());
            RestartPosition();
        }

        public void PerformMovement()
        {
            if (_isPlaying == false)
            {
                ChangeState(PlayerState.Sliding);
                _isPlaying = true;
                StartCoroutine(Movement());
            }
        }

        private void ChangeState(PlayerState newState)
        {
            _playerStateInvoker.ChangeInvokeState(newState);
            _playerStateInvoker.Invoke();
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
            Stop();
        }

        private void RestartPosition()
        {
            _collider.offset = new Vector2(_collider.offset.x, _baseOffset);
            _collider.size = new Vector2(_collider.size.x, _baseHeight);
        }
    }
}