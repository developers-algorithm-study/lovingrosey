using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ggiyaaaaaaaaaaaaak12 : MonoBehaviour
{
    //Baekjoon 2739

    int N;
    int m;
    int O = 1;
        
    void Start()
    {
        N = Random.Range(1, 10);

        for (m = N; O < 10; m * O)
        {
            Debug.Log(m);
            O++;
        }
    }
}
