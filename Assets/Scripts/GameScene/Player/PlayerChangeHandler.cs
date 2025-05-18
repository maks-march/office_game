using GameScene;
using Resources;
using StateChangers;
using UnityEngine;

namespace Invokers
{
    public class PlayerChangeHandler : ChangeHandler
    {
        [SerializeField] private Animator _animator;
        [SerializeField] private MovingOnEvents _movingOnEvents;
        private AnimatorParamsChanger _animatorParamsChanger;

        private PlayerState _currentState;

        public PlayerState currentState { get => _currentState; }

        protected override void OnAwake()
        {
            _currentState = PlayerState.Idle;
            _animatorParamsChanger = new AnimatorParamsChanger(_animator);
        }

        protected override void OnEvent(IInvoker invoker)
        {
            MoveInputInvoker inputInvoker = (MoveInputInvoker)invoker;

            PlayerState newState = inputInvoker.NewPlayerState;

            if (_currentState == PlayerState.Idle)
            {
                newState = PlayerState.Run;
                _currentState = newState;
                _animatorParamsChanger.ChangeParams(newState);
                return;
            }

            bool started = _movingOnEvents.Move(newState);
            if (started)
            {
                _animatorParamsChanger.ChangeParams(newState);
            }

        }
    }
}