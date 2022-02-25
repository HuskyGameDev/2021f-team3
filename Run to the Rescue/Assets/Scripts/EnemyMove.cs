using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private Vector3[] positions;

    private int index;

    private float scrollSpeed = -4f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.velocity = new Vector2(scrollSpeed, 0);
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x, positions[index].y), Time.deltaTime * speed);
        Invoke("SpeedUp", 10);

        if (transform.position.y == positions[index].y)
        {
            if (index == positions.Length - 1)
            {
                index = 0;
            }
            else
            {
                index++;
            }
        }
    }
    void speedUp()
    {
        scrollSpeed = scrollSpeed - 10;
    }
}
