using System.Collections;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    public GameObject[] coinPrefabs;
    public Transform[] spawnPoints;
    public float spawnInterval = 2f;
    public float spawnRange = 5f;

    void Start()
    {
        StartCoroutine(SpawnObstaclesAndCoins());
    }

    IEnumerator SpawnObstaclesAndCoins()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);

            bool spawnCoin = Random.value > 0.5f;

            if (spawnCoin)
            {
                int coinIndex = Random.Range(0, coinPrefabs.Length);
                int spawnPointIndex = Random.Range(0, spawnPoints.Length);
                Vector3 spawnPosition = spawnPoints[spawnPointIndex].position + new Vector3(0, 0, Random.Range(-spawnRange, spawnRange));
                Instantiate(coinPrefabs[coinIndex], spawnPosition, Quaternion.identity);
            }
            else
            {
                int obstacleIndex = Random.Range(0, obstaclePrefabs.Length);
                int spawnPointIndex = Random.Range(0, spawnPoints.Length);
                Vector3 spawnPosition = spawnPoints[spawnPointIndex].position + new Vector3(0, 0, Random.Range(-spawnRange, spawnRange));
                Instantiate(obstaclePrefabs[obstacleIndex], spawnPosition, Quaternion.identity);
            }
        }
    }
}
