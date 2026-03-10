using System;
using UnityEngine;

public class Large_Spawner : MonoBehaviour
{
    private float _spawnTimer;
    private float _spawnInterval = 1f;

    [SerializeField] private ObjectPooler pool;

    // Update is called once per frame
    void Update()
    {
        _spawnTimer -= Time.deltaTime;
        if (_spawnTimer <= 0)
        {
            _spawnTimer = _spawnInterval;
            SpawnFish();
        }
    }

    // Spawn enemy after _spawnInterval
    private void SpawnFish()
    {
        GameObject spawnedObject = pool.GetPooledObject();
        spawnedObject.transform.position = transform.position;
        spawnedObject.SetActive(true);
    }
}
