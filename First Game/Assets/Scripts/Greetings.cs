using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conversation : MonoBehaviour
{
    public int GreetingNumber = 5;
    
    void Greet()
    {
        switch (GreetingNumber)
        {
            case 5:
               print("Henlo");
               break;
            case 4: 
                print("Hi?");
                break;
            case 3:
                print("How are ya?");
                break;
            case 2:
                print("bye");
                break;
            case 1:
                print("Good to see you!");
                break;
            default:
                print("That is not correct...");
                break;
        }
    }
// got this from a youtube tutorial https://www.youtube.com/watch?v=JwhWiLlNz3U
}
