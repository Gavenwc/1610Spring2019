using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnFunctions : MonoBehaviour
{
    public int A, B, C;

    private int Add()
    {
        C = A + B;
            
        return C;
    }
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
