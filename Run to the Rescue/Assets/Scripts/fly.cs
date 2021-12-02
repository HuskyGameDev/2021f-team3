using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour
{
    public SpriteRenderer sp;
    public Sprite flying;
    public Sprite running;
    private Rigidbody2D rb;
    private float jumpForce = 60f;
    public bool isFlying;

    void Start()
    {
        isFlying = false;
        rb = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            isFlying = true;
        }
        else
        {
            isFlying = false;
        }
        
    }

    private void FixedUpdate()
    {
        switch (isFlying)
        {
            case true:
                rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Force);
                sp.sprite = flying;
                break;
            case false:
                rb.AddForce(new Vector2(0f, 0f), ForceMode2D.Force);
                break;
        }

    }
    /*
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!isFlying) 
        {
            sp.sprite = running;
        }


    }
    */
    }
