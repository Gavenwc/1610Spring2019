using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Animal : MonoBehaviour
{
    public UnityEvent Event;
    public string Name;
    public FloatData Health;
    public FloatData Speed;
    public bool CanMove;

    private Color newColor;

    public Color SkinColor;

    public void Move()
    {
        print("Move");
    }
    
    void Start()
    {
       Event.Invoke(); 
    }

    void Update()
    {
        
    }
}
