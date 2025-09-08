using UnityEngine;

// else문 : 아니면
public class ElseDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(1 != 1)
        {
            //실행문 1
            Debug.Log("조건식이 참이면 실행문1을 실행합니다");
        }
        else
        {
            //실행문 2
            Debug.Log("조건식이 거짓이면 실행문2을 실행합니다");
        }
    }
}

/*
else문 : 아니면
if 조건식이 참일때면 else 실행문2는 실행하지 않습니다
if 조건식이 거짓일때면 else 실행문2를 실행합니다

if(조건식)
{
    //실행문 1
}
else
{
    //실행문 2
}
//실행문 3

1. 조건식이 참일 경우
실행문 1 -> 실행문 3 실행

2. 조건식이 거짓일 경우
실행문 2 -> 실행문 3 실행

*/