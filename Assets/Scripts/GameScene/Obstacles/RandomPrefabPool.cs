using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RandomPrefabPool : MonoBehaviour
{
    [System.Serializable]
    public class PoolItem
    {
        public GameObject prefab;
        private int _initialSize = 2;

        public int InitialSize { get { return _initialSize; } }
    }

    [SerializeField] private PoolItem[] _poolItems;

    private List<GameObject> _objectPool = new List<GameObject>();

    private void Awake()
    {
        foreach (var item in _poolItems)
        {
            for (int i = 0; i < item.InitialSize; i++)
            {
                GameObject instance = Instantiate(item.prefab, transform);
                instance.SetActive(false);
                _objectPool.Add(instance);
            }
        }
    }

    public GameObject GetRandomObject() => GetObject();

    private GameObject GetObject()
    {
        if (_objectPool.Count == 0) return null;

        int index = Random.Range(0, _objectPool.Count);
        int active_amount = 0;

        while (_objectPool[index].activeInHierarchy && active_amount < _objectPool.Count)
        {
            index = Random.Range(0, _objectPool.Count - 1);
            active_amount += 1;
        }

        if (active_amount == _objectPool.Count) return null;

        _objectPool[index].SetActive(true);
        return _objectPool[index];
    }
}
