using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpSpeed = 2f;
    public Rigidbody2D rb;
    private bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        float jump = Input.GetAxis("Jump");
        if (move != 0)
        {
            rb.velocity = new Vector2(move * speed, 0);
        }
        if (jump != 0  && isGrounded)
        {
            rb.velocity = new Vector2(0, jump * jumpSpeed);
        }

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Detectar contacto con el suelo
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }


}
