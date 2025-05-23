using Assets.Scripts.GameScene.Player;
using Resources;
using System.Collections;
using UnityEngine;


namespace GameScene
{
    [RequireComponent(typeof(JumpCollisionCheck))]
    [RequireComponent(typeof(PlayerStateInvoker))]
    public class Jump : MonoBehaviour, IMovePerformer
    {
        [SerializeField] private AnimationCurve _curve;
        [SerializeField] private float _distance = 4f;
        [SerializeField] private GroundRaycaster _rayCaster;

        private PlayerStateInvoker _playerStateInvoker;
        private Vector3 _jumpDirection = Vector3.up;
        private Vector3 _startPosition;
        private bool _isPlaying = false;
        private JumpCollisionCheck _check;

        public PlayerState State { get => PlayerState.Jump; }
        public bool IsPlaying { get { return _isPlaying; } }

        private void Awake()
        {
            _check = GetComponent<JumpCollisionCheck>();
            _playerStateInvoker = GetComponent<PlayerStateInvoker>();
        }

        public void Stop()
        {
            _isPlaying = false;
            ChangeState(PlayerState.Run);
            StopCoroutine(Movement());
        }

        public void PerformMovement()
        {
            _startPosition = gameObject.transform.position;
            if (_rayCaster.IsGrounded() && _isPlaying == false)
            {
                ChangeState(PlayerState.Jump);
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
            var endPosition = _startPosition + _jumpDirection * _distance;
            float time = 0f;
            while (time < 1f)
            {
                if (_check.IsCollided)
                {
                    break;
                }
                time += Time.deltaTime / ConstantResources.MoveDuration;
                Vector3 newPosition = Vector3.Lerp(_startPosition, endPosition, time);
                float offset = _curve.Evaluate(time);
                newPosition += _jumpDirection * offset;
                transform.position = newPosition;
                yield return null;
            }
            Stop();
        }
    }
}