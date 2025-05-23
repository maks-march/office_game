using UnityEngine;
using Invokers;


namespace GameScene
{
    public class LoseChangeHandler : ChangeHandler
    {
        [SerializeField] private GameObject _loseMenu;
        [SerializeField] private PauseChangeHandler _pauseChangeHandler;

        protected override void OnEvent(IInvoker invoker)
        {
            _pauseChangeHandler.StopGame();
            _loseMenu.SetActive(true);
        }
    }
}