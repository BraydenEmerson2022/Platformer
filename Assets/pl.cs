using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pl : MonoBehaviour
{
    public float jumpPower = 1;

    public float moveSpeed;

    Rigidbody2D rb;

    SpriteRenderer sr;


    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        sr = gameObject.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * jumpPower);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector3(moveSpeed, rb.velocity.y, 0);
            sr.flipX = false;
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3(-moveSpeed, rb.velocity.y, 0);
            sr.flipX = true;
        }
    }
}
