using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float minTime, maxTime;
    float spawnTimeRate;
    public GameObject[] obstaculos;
    public Transform[] spawnPoints;

    private void Awake()
    {
        spawnTimeRate = Time.time + Random.Range(minTime, maxTime);
    }

    public void Espaunear()
    {
        int indice = Random.Range(0, obstaculos.Length);
        int lugar = Random.Range(0, spawnPoints.Length);
        Instantiate(obstaculos[indice], spawnPoints[lugar].position , obstaculos[indice].transform.rotation);
        spawnTimeRate = Time.time + Random.Range(minTime, maxTime);
    }

    private void Update()
    {
        
        if(Time.time > spawnTimeRate)
        {
            Espaunear();
        }

    }


}
