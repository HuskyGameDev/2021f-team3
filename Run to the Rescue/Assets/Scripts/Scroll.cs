using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    public BoxCollider2D collider;
    public Rigidbody2D rb;

    private float width;

    public float scrollSpeedDad = -4f;

// Start is called before the first frame update
void Start()
    {
    
        collider = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();

        width = collider.size.x*2;
        collider.enabled = false;

        rb.velocity = new Vector2(scrollSpeedDad, 0);
        InvokeRepeating("SpeedUp", 1, 2);
    }   

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(scrollSpeedDad, 0);
        if (transform.position.x < -width)
        {
            Vector2 resetPosition = new Vector2(width * 2f, 0);
            transform.position = (Vector2)transform.position + resetPosition;
        }
    }
    void SpeedUp()
    {
        scrollSpeedDad = scrollSpeedDad - .35f;
    }
}