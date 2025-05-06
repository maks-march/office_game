using System.Collections;
using UnityEngine;


namespace GameScene
{
    public class SpawnObstacle : MonoBehaviour
    {
        private RandomPrefabPool _pool;

        private float _spawnTime;

        public float SpawnTime
        {
            get
            {
                return _spawnTime;
            }
            set
            {
                if (value >= 0)
                {
                    _spawnTime = value;
                }
            }
        }

        private void Start()
        {
            _spawnTime = 2f;
            _pool = GetComponent<RandomPrefabPool>();
            StartCoroutine(Spawn());
        }

        private IEnumerator Spawn()
        {
            while (true)
            {
                var instance = _pool.GetRandomObject();
                instance.SetActive(true);
                instance.transform.position = transform.position;
                instance.transform.rotation = transform.rotation;
                yield return new WaitForSeconds(_spawnTime);
            }
        }
    }
}