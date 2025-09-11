using UnityEngine;

public class MethodOverload : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //1234 출력
        PrintNumber(1234);
        PrintNumber(1234f);
        PrintNumber(1234L);
    }

    //숫자를 출력하는 함수 만들기
    //int형 정수를 매개변수로 입력 받아 출력하는 함수
    void PrintNumber(int number)
    {
        Debug.Log($"Int32: {number}");
    }

    //float형 실수를 매개변수로 입력 받아 출력하는 함수
    void PrintNumber(float number)
    {
        Debug.Log($"실수형: {number}");
    }

    //long형 정수를 매개변수로 입력 받아 출력하는 함수
    void PrintNumber(long number)
    {
        Debug.Log($"Int64: {number}");
    }

}

/*
MethodOverload : 함수의 다중 정의
: 동일한 이름의 메서드를 매개변수를 달리해서 여러개 생성(정의)
*/