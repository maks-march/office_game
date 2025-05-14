using UnityEngine;
using Invokers;


namespace GameScene
{
    public class LoseChangeHandler : ChangeHandler
    {
        [SerializeField] private GameObject _loseMenu;

        protected override void OnEvent(IInvoker invoker)
        {
            gameObject.transform.root.GetComponentInChildren<PauseChangeHandler>().StopGame();
            _loseMenu.SetActive(true);
        }
    }
}