using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class MoveCharacter : MonoBehaviour
{
    public UnityEvent OnGrounded, Offgrounded;


    public MoveBase CharacterMover;
    private CharacterController _controller;
    private Vector3 position;
    
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (_controller.isGrounded)
        {
            OnGrounded.Invoke();
        }
        else
        {
            Offgrounded.Invoke();
        }

        CharacterMover.Move(_controller);
      

        
    }
}
