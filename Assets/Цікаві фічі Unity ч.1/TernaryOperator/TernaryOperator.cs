using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TernaryOperator : MonoBehaviour
{
    
    void Start()
    {
        int score = 20;
        string output;

        //This is an example Ternary Operation that chooses a message based
        //on the variable "score".
        output = score > 10 ? "Next level" : "Try again";

    }

    
}
