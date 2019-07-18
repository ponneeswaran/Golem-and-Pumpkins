﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject pumpkin;
    private int prevSpawn;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(startSpawning());
    }

    IEnumerator startSpawning()
    {
        yield return new WaitForSeconds(Random.Range(1f, 3.5f));
        int spawnPoint = Random.Range(0, spawnPoints.Length);
        while (spawnPoint == prevSpawn)
        {
            spawnPoint = Random.Range(0, spawnPoints.Length);
        }

        Instantiate(pumpkin, spawnPoints[spawnPoint].position,
            Quaternion.identity);

        prevSpawn = spawnPoint;

        StartCoroutine(startSpawning());
    }
}
