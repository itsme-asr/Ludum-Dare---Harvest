using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //[SerializeField] private GameObject toSpawn;
    [SerializeField] private float time = 1.3f;
    [SerializeField] private GameObject[] fruits;
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
        Vector3 position = new Vector3(Random.Range(-6f, 6f), Random.Range(3.74f, 0.29f), Random.Range(0f, 0f));
        GameObject fruit = Instantiate(fruits[Random.Range(0, fruits.Length)], position, Quaternion.identity);
        Destroy(fruit, 5f);
    }

}
