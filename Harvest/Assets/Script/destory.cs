using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destory : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Fruit")
        {
            Destroy(col.gameObject);
        }
    }
}
