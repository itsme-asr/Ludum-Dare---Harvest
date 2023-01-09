using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public float heal = 100f;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Fruit")
        {
            heal = heal - 5;
            Destroy(col.gameObject);
        }
    }
}
