using UnityEngine;

public class DoubleDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]변수 선언 및 초기화
        float f = 3.14f;
        double d = 3.14;
        decimal m = 3.14M;

        float min = float.MinValue;
        float max = float.MaxValue;

        //[2]변수 사용
        Debug.Log(f);
        Debug.Log(d);
        Debug.Log(m);

        Debug.Log(min);
        Debug.Log(max);

    }
}

/*
실수형 데이터 형식
Float  : 32비트 부동 소수점 숫자
Double : 64비트 부동 소수점 숫자
Decimal : 128비트 부동 소수점 숫자





*/