using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ggiyaaaaaaaaaaaaak11 : MonoBehaviour
{
    //Baekjoon 14681

    int x;
    int y;

    int PlusMinusX;
    int PlusMinusY;
    //PlusMinus = 1: n < 0
    //PlusMinus = 2: n > 0

    void Start()
    {
        PlusMinusX = Random.Range(1, 3);
        PlusMinusY = Random.Range(1, 3);

        if (PlusMinusX == 1) x = Random.Range(-1000, 0);
        else if (PlusMinusX == 2) x = Random.Range(1, 1001);

        if (PlusMinusY == 1) y = Random.Range(-1000, 0);
        else if (PlusMinusY == 2) y = Random.Range(1, 1001);

        if (x > 0 && y > 0) Debug.Log("1");
        else if(x < 0 && y > 0) Debug.Log("2");
        else if (x < 0 && y < 0) Debug.Log("3");
        else if (x > 0 && y < 0) Debug.Log("4");
    }
}
