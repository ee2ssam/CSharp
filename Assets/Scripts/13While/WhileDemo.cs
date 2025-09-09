using UnityEngine;

public class WhileDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //안녕하세요를 3번 반복 출력하는 프로그램 구현
        /*for (int i = 0; i < 3; i++) //3번 반복
        {
            //반복 실행문
            Debug.Log("안녕하세요");
        }*/

        //초기식
        int i = 0;

        while (i < 3) //조건식 참이면 반복문 실행, 거짓이면 while문 종료
        {
            //반복 실행문
            Debug.Log("안녕하세요");

            //증감식
            i++;        //1 -> 2 -> 3
        }
    }
}


/*
//조건식이 true이면 반복 실행문을 실행한다
//조건식이 false이면 whlie문을 종료한다
//조건식 true, false

while(조건식)
{
    //반복 실행문
}

조건식 판별(참) -> 반복문 실행 -> 조건식 판별(참) -> 반복문 실행
-> 조건식 판별(거짓) -> whlie문 종료

== 무한반복문
while(true)
{
    //반복 실행문
}
*/