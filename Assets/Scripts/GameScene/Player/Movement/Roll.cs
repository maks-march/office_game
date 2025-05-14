using Resources;
using System.Collections;
using UnityEngine;


namespace GameScene
{
    [RequireComponent(typeof(Collider2D))]
    public class Roll : MonoBehaviour, IMovePerformer
    {
        private Collider2D _collider;

        public PlayerState State { get => PlayerState.Roll; }

        public void Stop()
        {
            StopCoroutine(Movement());
        }

        public void PerformMovement()
        {
            StartCoroutine(Movement());
        }
        private IEnumerator Movement()
        {
            yield break;
        }
    }
}