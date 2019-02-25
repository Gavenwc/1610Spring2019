using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
    public bool CanWalk = true;
    public int Number;
    public string Password;
    void Start()
    {
        
    }

   private void Update()
    {
        if (CanWalk)
        {
            print("True");
        }
        else
        {
            print(false);
        }

        if (Number >= 10)
        {
            print("Greater");
        }
        else
        {
            print("Lesser");
        }

        if (Password == "YaBoi")
        {
            print("...acceptable...");
        }
        else
        {
            print("Hell Nah");
        }
    }
}
