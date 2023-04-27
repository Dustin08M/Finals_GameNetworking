using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObstacleSpawnerScript : MonoBehaviour
{
    [SerializeField] private GameObject[] SpawnPoints = new GameObject[3];
    [SerializeField] private GameObject[] ObstaclePrefabs;
    void Start()
    {
        SpawnPoints[0] = GameObject.Find("ObjSpawner1");
        SpawnPoints[1] = GameObject.Find("ObjSpawner2");
        SpawnPoints[2] = GameObject.Find("ObjSpawner3");
        PickAndSpawnObj();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void PickAndSpawnObj()
    {
        int SpawnIndex_SpawnPnts = Random.Range(0, SpawnPoints.Length); //For choosing spawnPoints;
        GameObject AreaToSpawn = SpawnPoints[SpawnIndex_SpawnPnts]; // The spawnpoint to choose when instantiating a randomly chosen object
        int SpawnIndex_Obstacle = Random.Range(0, ObstaclePrefabs.Length); //For picking variety of objs;
        GameObject ObjToSpawn = ObstaclePrefabs[SpawnIndex_Obstacle];// The obstacle to spawn on a chosen spawnpoint

        GameObject SpawnObjToSpawnPoint = Instantiate(ObjToSpawn,AreaToSpawn.transform.position,Quaternion.identity);

    }
}
