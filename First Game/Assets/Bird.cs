using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animal
{
    public Color FeatherColor;
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = SkinColor;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,10,0);
    }
}