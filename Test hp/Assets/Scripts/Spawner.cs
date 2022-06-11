using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] enemy;
    public Transform[] spawnPoint;

    private int rand;
    private int randPos;
    public float startTimeBtwSpawns;
    private float timeBtwSpawns;

    void Start()
    {
        timeBtwSpawns = startTimeBtwSpawns; 
    }

    void Update()
    {
      if(timeBtwSpawns <= 0)
        {
            rand = Random.Range(0, enemy.Length);
            randPos = Random.Range(0, spawnPoint.Length);
            Instantiate(enemy[rand], spawnPoint[randPos].transform.position, Quaternion.identity);
            timeBtwSpawns = startTimeBtwSpawns;
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
    }
}
