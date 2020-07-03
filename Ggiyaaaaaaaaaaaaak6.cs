using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ggiyaaaaaaaaaaaaak6 : MonoBehaviour
{
    //Baekjoon 10430

    double A = 5;
    double B = 8;
    double C = 4;

    void Start()
    {
        double AaB = A + B;
        double ApC = A % C;
        double BpC = B % C;
        double AmB = A * B;

        Debug.Log(AaB&C);
        Debug.Log(ApC+BpC);
        Debug.Log(AmB%C);
        Debug.Log(ApC*BpC);
    }
    
}
