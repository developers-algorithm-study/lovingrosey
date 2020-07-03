using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ggiyaaaaaaaaaaaaak8 : MonoBehaviour
{
    //Baekjoon 1330

    int A = 1;
    int B = 2;
    
    void Start()
    {
        if (A < B) Debug.Log("<");

        A = 10;

        if (A > B) Debug.Log(">");

        A = 5;
        B = 5;

        if (A == B) Debug.Log("==");
    }
    
}
