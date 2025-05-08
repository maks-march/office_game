using UnityEngine;
using Invokers;
using Pausing;

namespace GameScene
{
    public class LoseChangeHandler : ChangeHandler
    {
        [SerializeField] private GameObject _loseMenu;

        protected override void Awake()
        {
            base.Awake();
        }

        protected override void OnEvent(IInvoker invoker)
        {
            gameObject.transform.root.GetComponentInChildren<PauseChangeHandler>().StopGame();
            _loseMenu.SetActive(true);
        }
    }
}