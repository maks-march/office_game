using UnityEngine;
using Invokers;


namespace ChangeHandlers
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