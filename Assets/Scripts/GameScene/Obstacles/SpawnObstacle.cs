using System.Collections;
using UnityEngine;


namespace GameScene
{
    public class SpawnObstacle : MonoBehaviour
    {
        [SerializeField] private float _spawnTime = 2f;
        [SerializeField] private float _startTime = 0f;
        private RandomPrefabPool _pool;


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

        public void StartSpawning()
        {
            _pool = GetComponent<RandomPrefabPool>();
            StartCoroutine(Spawn());
        }

        private IEnumerator Spawn()
        {
            yield return new WaitForSeconds(_startTime);
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