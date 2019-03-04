using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MoveBase : ScriptableObject
{
   protected static Vector3 position;
   public static float Speed = 30;
   public static float JumpForce = 1.5f;
   public static float Gravity = -3;
   protected static CharacterController _controller;
   
   public abstract void Move(CharacterController controller);
}
