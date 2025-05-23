using Invokers;
using UnityEngine;
using Obstacles;


namespace ChangeHandlers
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