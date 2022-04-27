using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerObjetos : MonoBehaviour
{


    public GameObject[] obstaculos;



    public float timeSpawn = 1;

    public float repeatSpawnRate = 3;


    public Transform xRangeLeft;
    public Transform xRangeRight;
    public Transform yRangeUp;
    public Transform yRangeDown;




    
    void Start()
    {
        InvokeRepeating("SpawnEnemies", timeSpawn,repeatSpawnRate);
    }

    
    void Update()
    {
        
    }

    public void SpawnEnemies()
    {

        Vector3 spawnPosition = new Vector3(0, 0, 0);

        spawnPosition = new Vector3(Random.Range(xRangeLeft.position.x, xRangeRight.position.x), Random.Range(yRangeDown.position.y, yRangeUp.position.y),0);

        GameObject obstaculo = Instantiate(obstaculos[Random.Range(0,obstaculos.Length)],spawnPosition,gameObject.transform.rotation);
    }
}
