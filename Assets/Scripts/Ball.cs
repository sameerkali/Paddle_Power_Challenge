using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class Ball : MonoBehaviour
{
    [SerializeField] float speed;
     [SerializeField] Rigidbody2D rb;
    private Vector3 StartPosition;

    void Start()
    {
        StartPosition = transform.position;
        Launch();
    }
   /* public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = StartPosition;
        Launch();
    }*/
    public void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;  
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }
}
