using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject toSpawn;
    [SerializeField] private float time = 1f;
    private float currentTime;
    void Start()
    {

    }

    private void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
        }
        else
        {
            fruitSpawn();
            currentTime = time;

        }

    }


    private void fruitSpawn()
    {
        Vector3 position = new Vector3(Random.Range(-7.77f, 8f), Random.Range(3.74f, 0.29f), Random.Range(0f, 0f));
        GameObject fruit = Instantiate(toSpawn, position, Quaternion.identity);
        Destroy(fruit, 5f);
    }

}
