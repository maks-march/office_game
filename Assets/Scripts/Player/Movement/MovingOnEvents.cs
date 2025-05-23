using Resources;
using StateChangers;
using System.Collections.Generic;
using UnityEngine;


namespace Movement
{
    [RequireComponent(typeof(Jump))]
    [RequireComponent(typeof(Sliding))]
    public class MovingOnEvents : MonoBehaviour, IStateChanger
    {
        private IEnumerable<IMovePerformer> _movePerformers;


        private void Awake()
        {
            _movePerformers = GetComponents<IMovePerformer>();
        }

        public bool Move(PlayerState currentState)
        {
            bool isPlaying = false;
            foreach (var performer in _movePerformers)
            {
                if (currentState == performer.State)
                {
                    performer.PerformMovement();
                    isPlaying = performer.IsPlaying;
                } else
                {
                    performer.Stop();
                }
            }
            return isPlaying;
        }
    }
}