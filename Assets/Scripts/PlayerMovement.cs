using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 1;

    private Rigidbody2D rb;
    private Vector3 dir;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        dir = new Vector3(x, y, 0);
    }

    private void FixedUpdate()
    {
        rb.AddForce(dir * speed);
    }
}
