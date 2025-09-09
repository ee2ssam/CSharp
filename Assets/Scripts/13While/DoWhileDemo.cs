using UnityEngine;

public class DoWhileDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //안녕하세요 3회 반복 출력
        /*for (int i = 0; i < 3; i++) //3번 반복
        {
            //반복 실행문
            Debug.Log("안녕하세요");
        }*/

        //[1]초기식
        /*int i = 4;
        
        while (i < 3) //[2]조건식
        {
            //반복 실행문
            Debug.Log("안녕하세요");

            //[3]증감식
            i++;
        }*/

        // i=4 -> i<3(거짓) -> while문 종료

        //[1]초기식
        int i = 4;

        do
        {
            //반복 실행문
            Debug.Log("안녕하세요");

            //[2]증감식
            i++;

        } while (i < 3); //[3]조건식

        // i=4 -> 출력 -> i:5 ->  i<3(거짓) -> while문 종료

        //초기식 i=0 -> 출력 -> i:1 -> i<3(참) -> 출력 -> i:2
        // -> i<3(참) -> 출력 -> i:3 -> i<3(거짓) -> while문 종료

    }
}

/*
//반복 실행문을 실행
//조건식 판별하여 참이면 반복 실행문 실행
//거짓이면 while문 종료
//무조건적으로 반복실행문을 1회 실행

do
{
    //반복 실행문

} while (조건식)



*/