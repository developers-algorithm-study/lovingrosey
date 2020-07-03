using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ggiyaaaaaaaaaaaaak9 : MonoBehaviour
{
    //Baekjoon 9498

    int test;
    
    void Start()
    {
        test = Random.Range(0, 101);

        if (test >= 90 && test <= 100) Debug.Log("A");
        else if (test >= 80 && test <= 89) Debug.Log("B");
        else if (test >= 70 && test <= 79) Debug.Log("C");
        else if (test >= 60 && test <= 69) Debug.Log("D");
        else if (test <= 59) Debug.Log("F");
    }
    
}
