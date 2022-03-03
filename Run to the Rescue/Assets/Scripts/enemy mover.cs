using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymover : MonoBehaviour {

    public Scroll scroll;
    public GameObject scrollObject;
    public float scrollSpeed = -4f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        scroll = scrollObject.GetComponent<Scroll>(); 
        rb = GetComponent<Rigidbody2D>();

        rb.velocity = new Vector2(scrollSpeed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("SpeedUp", 3);
    }
}
