using UnityEngine;
using System.Collections.Generic;

public class ObjectPooler : MonoBehaviour
{
    [SerializeField] private GameObject Prefab;
    [SerializeField] public int poolSize = 3;
    private List<GameObject> _pool;

    void Start()
    {
        // Create pool
        _pool = new List<GameObject>();
        for (int i = 0; i < poolSize; i++)
        {
            CreateNewObject();
        }
    }

    private GameObject CreateNewObject()
    {
        GameObject obj = Instantiate(Prefab, transform);
        obj.SetActive(false);
        _pool.Add(obj);
        return obj;
    }

    // Activate gameobjects
    public GameObject GetPooledObject()
    {
        foreach(GameObject obj in _pool)
        {
            if (!obj.activeSelf)
            {
                return obj;
            }
        }
        return CreateNewObject();
    }
}
