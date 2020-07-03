using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ggiyaaaaaaaaaaaaak8 : MonoBehaviour
{
    //Baekjoon 1330
    
    int A;
    int B;
    
    void Start()
    {
        A = Random.Range(-10000, 10001);
        B = Random.Range(-10000, 10001);
        
        if (A < B) Debug.Log("<");
        else if (A > B) Debug.Log(">");
        else if (A == B) Debug.Log("==");
    }
    
}
