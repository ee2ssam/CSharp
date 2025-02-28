using UnityEngine;

public class RealNumberPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float f = 3.14f;
        double d = 3.14;
        decimal m = 3.14m;


        Debug.Log("float: " + f);
        Debug.Log("double: " + d);
        Debug.Log("decimal: " + m);
    }
}


/*
[Q]
실수형 값 float 3.14, double 3.14, decimal 3.14 값 출력하기

[output]
float: 3.14
double: 3.14
decimal: 3.14
*/