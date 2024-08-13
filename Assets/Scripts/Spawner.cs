
using UnityEditor.Timeline.Actions;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] prefabArray;

    public float spawnRangeX = 20;
    public float spawnRangeZ = 20;


    void SpawnRandomX()
    {
        int rIndex = Random.Range(0, prefabArray.Length);
        float spawnPosX = Random.Range(-spawnRangeX, spawnRangeX);
        Instantiate(prefabArray[rIndex], new Vector3(spawnPosX, 0, spawnRangeZ), prefabArray[rIndex].transform.rotation);

    }

    void SpawnRandomZLeft()
    {
        int rIndex = Random.Range(0, prefabArray.Length);
        float spawnPosZ = Random.Range(-5, 20);
        Instantiate(prefabArray[rIndex], new Vector3(-25, 0, spawnPosZ), Quaternion.Euler(0,90,0));

    }
        void SpawnRandomZRight()
    {
        int rIndex = Random.Range(0, prefabArray.Length);
        float spawnPosZ = Random.Range(-5, 20);
        Instantiate(prefabArray[rIndex], new Vector3(25, 0, spawnPosZ), Quaternion.Euler(0,-90,0));

    }


    void DifficultyIncreaser()
    {
         InvokeRepeating("SpawnRandomX",0,1.5f);
          InvokeRepeating("SpawnRandomZLeft",0,4f);
          InvokeRepeating("SpawnRandomZRight",0,4f);
    }

  
    void Start()
    {

        //USE THIS FOR REPATING SOMETHIGN ONLINE 
          InvokeRepeating("DifficultyIncreaser",2,50f);
     


    }
}
