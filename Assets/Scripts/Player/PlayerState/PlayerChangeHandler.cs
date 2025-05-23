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
        [SerializeField] private PlayerStateChanger _playerStateChanger;
        private AnimatorParamsChanger _animatorParamsChanger;

        public PlayerState currentState { get => _playerStateChanger.GetPlayerState; }

        protected override void OnAwake()
        {
            _animatorParamsChanger = new AnimatorParamsChanger(_animator);
        }

        protected override void OnEvent(IInvoker invoker)
        {
            MoveInputInvoker inputInvoker = (MoveInputInvoker)invoker;

            PlayerState newState = inputInvoker.NewPlayerState;

            if (currentState == PlayerState.Idle)
            {
                newState = PlayerState.Run;
                _playerStateChanger.ChangeState(newState);
                _animatorParamsChanger.ChangeParams(newState);
                return;
            }

            if (newState == PlayerState.Fail)
            {
                _movingOnEvents.Move(newState);
                _animatorParamsChanger.ChangeParams(newState);
            }

            if (currentState == PlayerState.Run) 
            {
                StartMove(newState);
                return;
            }

            if (currentState == PlayerState.Jump && newState == PlayerState.Sliding)
            {
                StartMove(newState);
                return;
            }
        }

        private void StartMove(PlayerState newState)
        {
            bool started = _movingOnEvents.Move(newState);
            if (started)
            {
                _animatorParamsChanger.ChangeParams(newState);
            }
        }
    }
}