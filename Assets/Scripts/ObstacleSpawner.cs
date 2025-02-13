using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;

    public float spawnTimeMin, spawnTimeMax;    // Tempo min e max di spawn 

    float timer;                                // Tempo di spawn

    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(spawnTimeMin, spawnTimeMax);   // Valore casuale dato in base al valore
    }
    // Update is called once per frame
    void Update()
    {
            SpawnObstacles();
    }
            void SpawnObstacles()
        {
            timer -= Time.deltaTime;

            if(timer <=0)
            {
                int r = Random.Range(0, obstaclePrefabs.Length);  //Creazione variabile temp. con assegnazione lunghezza
                Instantiate(obstaclePrefabs[r], transform.position, Quaternion.identity);   //Spawn dell'oggetto all'interno dell'array ad una posizione gestendo la rotazione

                timer = Random.Range(spawnTimeMin, spawnTimeMax);
            }
        }
    }

