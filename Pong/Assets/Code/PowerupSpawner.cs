using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpawner : MonoBehaviour
{
    public static PowerupSpawner Instance;

    public float maxX;
    public float maxY;
    public float spawnRate;
    public List<GameObject> powerups;

    void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        StartCoroutine(SpawnCo());
    }

    public void ClearPowerups()
    {
/*        GameObject[] allPowerUps = FindObjectsOfType<Powerup>();
        foreach (Powerup powerup in allPowerUps)
        {
            Destroy(powerup.gameObject);
        }*/
    }

    void SpawnRandomPowerup()
    {
        int randIndex = Random.Range(0, powerups.Count);

        float randX = Random.Range(-maxX, maxX);
        float randY = Random.Range(-maxY, maxY);

        Vector2 spawnPosition = new Vector2(randX, randY);

        GameObject powerup = Instantiate(powerups[randIndex], spawnPosition, transform.rotation, transform);
        Destroy(powerup.gameObject, spawnRate * 2);
    }

    private IEnumerator SpawnCo()
    {
        yield return new WaitForSeconds(spawnRate);
        SpawnRandomPowerup();
        StartCoroutine(SpawnCo());
    }
}
