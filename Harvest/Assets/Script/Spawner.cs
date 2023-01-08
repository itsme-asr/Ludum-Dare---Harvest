using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject toSpawn;
    [SerializeField] private int numberofSpawn = 4;
    void Start()
    {
        Clone();

    }


    private void Clone()
    {
        Vector3 position = new Vector3(Random.Range(-7.77f, 8f), Random.Range(3.74f, 0.29f), Random.Range(0f, 0f));
        Instantiate(toSpawn, position, Quaternion.identity);
    }
}
