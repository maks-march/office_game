using Invokers;
using UnityEngine;

namespace GameScene
{
    [RequireComponent(typeof(SpawnObstacle))]
    public class SpawnStarter : ChangeHandler
    {
        private SpawnObstacle _spawner;

        protected override void OnAwake()
        {
            _spawner = GetComponent<SpawnObstacle>();
        }

        protected override void OnEvent(IInvoker invoker)
        {
            StartSpawner();
        }

        private void StartSpawner()
        {
            _spawner.StartSpawning();
            this.enabled = false;
        }
    }
}