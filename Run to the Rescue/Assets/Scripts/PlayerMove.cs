using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public CharacterController2D cont;
    float horizontalMove = 0f;
    public float runSpeed = 40f;
    bool jump = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal")*runSpeed;
    }

     void FixedUpdate()
    {
        if (Input.GetButton("Jump"))
        {
            jump = true;
        }
        cont.Move(horizontalMove*Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
