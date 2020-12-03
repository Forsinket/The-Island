using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D control;

    public float runSpeed = 40f;

    float horizontalMove = 0f;


    bool jump = false;

    // Update is called once per frame
    void Update(){

        //El registro
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;

        }


    }

    private void FixedUpdate()
    {
        //Movimiento
        control.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
