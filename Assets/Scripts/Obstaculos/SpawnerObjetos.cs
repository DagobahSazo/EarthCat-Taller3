using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerObjetos : MonoBehaviour
{


    public GameObject[] obstaculos;

    public GameObject[] fruta;


    public float timeSpawn = 1;

    public float repeatSpawnRate = 3;


    public Transform xRangeLeft;
    public Transform xRangeRight;
    public Transform yRangeUp;
    public Transform yRangeDown;

    public float timeSpawnFruta = 1;

    public float repeatSpawnRateFruta = 2;

    public float difficultyTime = 0;





    void Start()
    {

        StartCoroutine("EnemyDifficulty");
        StartCoroutine("FruitsDifficulty");


    }

    
    void Update()
    {
        difficultyTime += Time.deltaTime;

        if (difficultyTime > 10 && difficultyTime<20)
        {
            repeatSpawnRate = 1;
        }
        if (difficultyTime > 20 && difficultyTime < 30)
        {
            repeatSpawnRate = 0.75f;
        }
        if (difficultyTime > 30 && difficultyTime < 40)
        {
            repeatSpawnRate = 0.25f;
            repeatSpawnRateFruta = 1;
        }
        if (difficultyTime > 40 && difficultyTime < 50)
        {
            repeatSpawnRate = 0.15f;
        }
        if (difficultyTime > 70 && difficultyTime < 80)
        {
            repeatSpawnRate = 0.10f;
        }
        if (difficultyTime > 100 && difficultyTime < 110)
        {
            repeatSpawnRate = 0.05f;
        }



    }


    IEnumerator EnemyDifficulty()
    {
        yield return new WaitForSeconds(repeatSpawnRate);
        SpawnEnemies();
        StartCoroutine("EnemyDifficulty");
    }

    IEnumerator FruitsDifficulty()
    {
        yield return new WaitForSeconds(repeatSpawnRateFruta);
        SpawnFruta();
        StartCoroutine("FruitsDifficulty");
    }


    public void SpawnEnemies()
    {

        Vector3 spawnPosition = new Vector3(0, 0, 0);

        spawnPosition = new Vector3(Random.Range(xRangeLeft.position.x, xRangeRight.position.x), Random.Range(yRangeDown.position.y, yRangeUp.position.y),0);

        GameObject obstaculo = Instantiate(obstaculos[Random.Range(0,obstaculos.Length)],spawnPosition,gameObject.transform.rotation);

        
    }


    public void SpawnFruta()
    {

        Vector3 spawnPosition = new Vector3(0, 0, 0);

        spawnPosition = new Vector3(Random.Range(xRangeLeft.position.x, xRangeRight.position.x), Random.Range(yRangeDown.position.y, yRangeUp.position.y), 0);

        GameObject frutas = Instantiate(fruta[Random.Range(0, fruta.Length)], spawnPosition, gameObject.transform.rotation);


    }
}
