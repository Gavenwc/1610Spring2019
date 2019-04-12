using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Conditionals : MonoBehaviour
{
    public UnityEvent OnEvent, OffEvent;
    
    public bool Onbool;
    public int Number;
    public string Password;
   

   private void Update()
    {
        if (Onbool)
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
