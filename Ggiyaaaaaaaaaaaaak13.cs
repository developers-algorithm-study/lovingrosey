using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ggiyaaaaaaaaaaaaak13 : MonoBehaviour
{
    //Baekjoon 10950

    int T;

    int A;
    int B;
        

    void Start()
    {
        T = Random.Range(1, 11);
        Debug.Log(T);

        for (F = 0; F < T; F++)
        {
            A = Random.Range(1, 11);
            B = Random.Range(1, 11);
            Debug.Log(A+B);
        }
    }
}
