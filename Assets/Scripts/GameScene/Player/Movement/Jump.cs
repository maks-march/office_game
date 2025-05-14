using Assets.Scripts.GameScene.Player;
using Resources;
using System.Collections;
using UnityEngine;

namespace GameScene
{
    public class Jump : MonoBehaviour, IMovePerformer
    {
        [SerializeField] private AnimationCurve _curve;
        [SerializeField] private float _duration = 2f;
        [SerializeField] private float _distance = 1f;
        [SerializeField] private GroundRaycaster _rayCaster;

        private Vector3 _jumpDirection = Vector3.up;
        private Vector3 _startPosition;

        public PlayerState State { get => PlayerState.Jump; }

        public void Stop()
        {
            StopCoroutine(Movement());
        }

        public void PerformMovement()
        {
            _startPosition = gameObject.transform.position;
            if (_rayCaster.IsGrounded())
            {
                StartCoroutine(Movement());
            }
        }


        private IEnumerator Movement()
        {
            var endPosition = _startPosition + _jumpDirection * _distance;
            float time = 0f;
            while (time < 1f)
            {
                time += Time.deltaTime / _duration;
                Vector3 newPosition = Vector3.Lerp(_startPosition, endPosition, time);
                float offset = _curve.Evaluate(time);
                newPosition += _jumpDirection * offset;
                transform.position = newPosition;
                yield return null;
            }
        }
    }
}