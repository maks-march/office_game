using UnityEngine;

namespace GameScene
{
    public class LoseHandler : MonoBehaviour
    {
        [SerializeField] private GameObject _loseMenu;

        public void Lose() => LoseGame();

        private void LoseGame()
        {
            Time.timeScale = 0f;
            _loseMenu.SetActive(true);
        }
    }
}