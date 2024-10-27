using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private Rigidbody2D body;
    private SpriteRenderer spriteRenderer;


    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        float x = Input.GetAxis("Horizontal");

        if (x > 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (x < 0)
        {
            spriteRenderer.flipX = false;
        }

        body.position += new Vector2(x, 0) * Time.deltaTime * speed;
    }
}
