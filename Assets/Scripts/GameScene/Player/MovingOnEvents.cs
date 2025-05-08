using Invokers;
using System.Collections;
using UnityEngine;


namespace GameScene
{
    public class MovingOnEvents : MonoBehaviour
    {
        [SerializeField] private AnimationCurve _curve;
        [SerializeField] private float _duration = 2f;
        [SerializeField] private float _distance;

        private PlayerActionsInvoker controls;
        private Animator _animator;
        private Vector3 _jumpDirection;
        private Vector3 _startPosition;
        private bool _isFailed;

        public void FailTriggered() => PerformFail();

        private void Awake()
        {
            controls = new PlayerActionsInvoker();
            _animator = GetComponent<Animator>();
            _jumpDirection = Vector3.up;
            _startPosition = transform.position;
        }

        private void OnEnable()
        {
            controls.Player.Enable();
            controls.Player.Jump.performed += ctx => PerformJump();
        }

        private void OnDisable()
        {
            controls.Player.Jump.performed -= ctx => PerformJump();
            controls.Player.Disable();
        }

        private void PerformFail()
        {
            _isFailed = true;
            _animator.SetTrigger("LoseEvent");
            gameObject.GetComponent<IInvoker>().Invoke(); // починить сука сделать привязку к state аниматора - разбить на классы
            // добавить подкат
        }

        private void PerformJump()
        {
            if (Mathf.Abs(_startPosition.y - transform.position.y) < 0.2)
            {
                StartCoroutine(Jump());
            }
        }

        private IEnumerator Jump()
        {
            var endPosition = _startPosition + _jumpDirection * _distance;
            float time = 0f;
            while (time < 1f)
            {
                if (_isFailed)
                {
                    break;
                }
                time += Time.deltaTime / _duration;
                Vector3 pos = Vector3.Lerp(_startPosition, endPosition, time);
                float offset = _curve.Evaluate(time);
                pos += _jumpDirection * offset;
                transform.position = pos;
                yield return null;
            }
        }
    }
}