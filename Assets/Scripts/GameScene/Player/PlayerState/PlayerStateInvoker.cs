using Invokers;
using Resources;
using UnityEngine;

namespace GameScene
{
    public class PlayerStateInvoker : Invoker
    {
        private PlayerState _newState = PlayerState.Idle;

        public PlayerState GetNewState { get { return _newState; } }

        public void ChangeInvokeState(PlayerState newState)
        {
            _newState = newState;
        }
    }
}