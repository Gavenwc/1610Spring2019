using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class MoveSingleJump : MoveBase
{
    public abstract override void Move(CharacterController controller);
    {
        if (_controller.isGrounded && Input.GetButton("Jump"))
        {
            position.y = JumpForce;
        }
        position.y += Gravity * Time.deltaTime;
        
        position.x = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        
        _controller.Move(position);
    }
}