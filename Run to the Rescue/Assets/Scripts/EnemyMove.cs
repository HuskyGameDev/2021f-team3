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
    public Scroll scroll;
    public GameObject scrollObject;
    private float scrollSpeed = -4f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        scrollObject = GameObject.FindWithTag("background");
        scroll = scrollObject.GetComponent<Scroll>();
        rb = GetComponent<Rigidbody2D>();

        rb.velocity = new Vector2(scrollSpeed, 0);
    }

    void Update()
    {
        scrollSpeed = scroll.scrollSpeedDad;
        rb.velocity = new Vector2(scrollSpeed, 0);
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x, positions[index].y), Time.deltaTime * speed);

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
}
