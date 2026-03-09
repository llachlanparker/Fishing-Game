using UnityEngine;

public class Small_Spawner : MonoBehaviour
{
    private float _spawnTimer;
    private float _spawnInterval = 1f;
    public GameObject Prefab;

    // Update is called once per frame
    void Update()
    {
        _spawnTimer -= Time.deltaTime;
        if (_spawnTimer <= 0)
        {
            _spawnTimer = _spawnInterval;
            SpawnEnemy();
        }
    }

    // Spawn enemy after _spawnInterval
    private void SpawnEnemy()
    {
        GameObject spawnedObject = GameObject.Instantiate(Prefab);
        spawnedObject.transform.position = transform.position;
    }
}
