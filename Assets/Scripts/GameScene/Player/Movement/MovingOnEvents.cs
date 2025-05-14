using Resources;
using StateChangers;
using System.Collections.Generic;
using UnityEngine;


namespace GameScene
{
    [RequireComponent(typeof(Jump))]
    [RequireComponent(typeof(Roll))]
    public class MovingOnEvents : MonoBehaviour, IStateChanger
    {
        private IEnumerable<IMovePerformer> _movePerformers;


        private void Awake()
        {
            _movePerformers = GetComponents<IMovePerformer>();
        }

        public void Move(PlayerState currentState)
        {
            foreach (var performer in _movePerformers)
            {
                if (currentState == performer.State)
                {
                    performer.PerformMovement();
                } else
                {
                    performer.Stop();
                }
            }
        }
    }
}