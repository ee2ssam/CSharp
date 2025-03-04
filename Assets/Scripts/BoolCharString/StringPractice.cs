using UnityEngine;

public class StringPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number = 3; //int형 변수 number선언하고 3으로 초기화한다
        string result = "홀수"; //string형 변수 result 선언하고 "홀수"로 초기화한다

        Debug.Log($"{number}은(는) {result}입니다");
    }
}

/*
[Q]
3, 홀수를 변수 선언하고 저장한다
문자열 보간법을 이용해서 저장된 데이터 출력하기

[output]
3은(는) 홀수입니다
*/
