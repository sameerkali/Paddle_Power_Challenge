using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] bool isPlayer1;
    [SerializeField] float speed;
    Rigidbody2D rb;
    private float movement;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isPlayer1)
        {
            movement = Input.GetAxisRaw("Vertical");
        }
        else
        {
            movement = Input.GetAxisRaw("Vertical1");
        }

        rb.velocity = new Vector2(0, movement * speed);
    }
}
