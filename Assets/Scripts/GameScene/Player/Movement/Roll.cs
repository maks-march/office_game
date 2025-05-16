using Resources;
using System.Collections;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;


namespace GameScene
{
    [RequireComponent(typeof(Collider2D))]
    public class Roll : MonoBehaviour, IMovePerformer
    {
        [SerializeField] private CapsuleCollider2D _collider;
        [SerializeField] private float _duration = 0.5f;

        private float _baseOffset;
        private float _baseHeight;
        private bool _isPlaying = false;

        public PlayerState State { get => PlayerState.Roll; }

        public void Stop()
        {
            _isPlaying = false;
            StopCoroutine(Movement());
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
            _baseOffset = _collider.offset.y;
            _baseHeight = _collider.size.y;
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
            _collider.offset = new Vector2(_collider.offset.x, _baseOffset);
            _collider.size = new Vector2(_collider.size.x, _baseHeight);

            _isPlaying = false;
        }
    }
}