using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ggiyaaaaaaaaaaaaak10 : MonoBehaviour
{
    //Baekjoon 2753

    int year;
    
    void Start()
    {
        year = Random.Range(1, 4001);

        if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0) Debug.Log("1");
        else Debug.Log("0");
    }
    
}
