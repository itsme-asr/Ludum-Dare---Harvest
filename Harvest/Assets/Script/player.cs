using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class player : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 6f;
    private Rigidbody2D rigBdy;
    [SerializeField] private Text score;
    private int collect = 0;
    private float dirX = 0f;

    //public float Health = 100f;
    void Start()
    {
        rigBdy = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        rigBdy.velocity = new Vector2(dirX * moveSpeed, rigBdy.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Fruit")
        {
            collect++;
            score.text = "Fruit: " + collect;
            Destroy(col.gameObject);

        }
    }
}
