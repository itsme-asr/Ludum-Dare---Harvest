using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 6f;
    private Rigidbody2D rigBdy;
    private float dirX = 0f;
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
}
