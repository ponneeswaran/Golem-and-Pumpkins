using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject pumpkin;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(startSpawning());
    }

    IEnumerator startSpawning()
    {
        yield return new WaitForSeconds(Random.Range(1f, 3.5f));
        Instantiate(pumpkin, spawnPoints[Random.Range(0, spawnPoints.Length)].position,
            Quaternion.identity);

        StartCoroutine(startSpawning());
    }
}
