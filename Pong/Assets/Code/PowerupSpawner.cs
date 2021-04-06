using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpawner : MonoBehaviour
{
    public float maxX;
    public float maxY;
    public float spawnRate;
    public List<Powerup> powerups;

    private void Start()
    {
        StartCoroutine(SpawnCo());
    }

    void SpawnRandomPowerup()
    {
        int randIndex = Random.Range(0, powerups.Count);

        float randX = Random.Range(-maxX, maxX);
        float randY = Random.Range(-maxY, maxY);

        Vector2 spawnPosition = new Vector2(randX, randY);

        Instantiate(powerups[randIndex], spawnPosition, transform.rotation, transform);   
    }

    private IEnumerator SpawnCo()
    {
        yield return new WaitForSeconds(spawnRate);
        SpawnRandomPowerup();
        StartCoroutine(SpawnCo());
    }
}
