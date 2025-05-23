using System.Collections;
using UnityEngine;

namespace Assets.Scripts.GameScene.Player
{
    public class GroundRaycaster : MonoBehaviour
    {
        private float _rayLength = 0.05f;

        public bool IsGrounded()
        {
            RaycastHit2D hit = Physics2D.Raycast(gameObject.transform.position, Vector2.down, _rayLength);
            return hit.collider != null;
        }
    }
}