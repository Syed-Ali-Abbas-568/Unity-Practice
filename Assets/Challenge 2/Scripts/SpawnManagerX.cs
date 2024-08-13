using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

  
    private float spawnInterval = 4.0f;
    
    private float elapsedTime=0.0f;

    


    // Start is called before the first frame update
    void Update()
    {
        elapsedTime+=Time.deltaTime;

        if(elapsedTime >= spawnInterval)
        {
            spawnInterval=Random.Range(3,8);
            elapsedTime=0;
            SpawnRandomBall();
        }
     
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        int index = Random.Range(0, ballPrefabs.Length);
        Instantiate(ballPrefabs[index], spawnPos, ballPrefabs[index].transform.rotation);
    }

}
