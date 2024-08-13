using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Android;

public class SpawnManagerScript : MonoBehaviour
{

    public GameObject[] enemyPrefab;
    public GameObject[] powerUp;
    public float spawnRange = 9;
    int enemyCount = 0;
    int waveCount = 1;

    // Start is called before the first frame update
    void Start()
    {





    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = GameObject.FindObjectsOfType<ChaseScript>().Length;
        if (enemyCount == 0)
        {
            SpawnEnemyWave(waveCount);
            waveCount += 1;
        }

    }


    private void SpawnEnemyWave(int enemiesToSpawn)
    {

        //power up spawn chance
        float spawnChance = Random.Range(0, 100);
        if (spawnChance <= 33)  //33% chance to spawn a power up
        {
            int choice= Random.Range(0,powerUp.Length);
            Instantiate(powerUp[choice], GenerateSpawnPosition(), powerUp[choice].transform.rotation);
        }
        for (int i = 0; i < enemiesToSpawn; i++)
        {

            int choice= Random.Range(0,enemyPrefab.Length);
            Instantiate(enemyPrefab[choice], GenerateSpawnPosition(), enemyPrefab[choice].transform.rotation);


        }
    }



    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(spawnRange, -spawnRange);
        float spawnPosZ = Random.Range(spawnRange, -spawnRange);
        return new Vector3(spawnPosX, 1, spawnPosZ);
    }
}
