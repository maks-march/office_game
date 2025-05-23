using UnityEngine;

namespace GameScene
{
    [RequireComponent(typeof(Collider2D))]
    public class JumpCollisionCheck : MonoBehaviour
    {
        private bool _isCollided = false;

        public bool IsCollided { get { return _isCollided; } }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            _isCollided = true;
        }


        private void OnTriggerExit2D(Collider2D collision)
        {
            _isCollided = false;
        }
    }
}