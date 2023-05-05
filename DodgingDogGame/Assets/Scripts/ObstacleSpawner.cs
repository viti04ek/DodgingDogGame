using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject ObstaclePrefab;
    public float SpawnRate;
    public float MaxXPosition;


    void Start()
    {
        StartSpawning();
    }


    void Spawn()
    {
        float randomX = Random.Range(-MaxXPosition, MaxXPosition);
        Vector2 spawnPosition = new Vector2(randomX, transform.position.y);

        Instantiate(ObstaclePrefab, spawnPosition, Quaternion.identity);
    }


    void StartSpawning()
    {
        InvokeRepeating("Spawn", 1f, SpawnRate);
    }


    public void StopSpawning()
    {
        CancelInvoke("Spawn");
    }
}
