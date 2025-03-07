using UnityEngine;

//안녕하세요를 3번 출력하는 프로그램
public class DoWhile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //for
        /*for (int i = 0; i < 3; i++)
        {
            //반복실행문
            Debug.Log("안녕하세요");
        }*/

        //while
        //[1]초기식
        /*int i = 4;

        while (i < 3)    //[2]조건식
        {
            //반복 실행문
            Debug.Log("안녕하세요");

            //증감식
            i++;
        }*/

        //doWhile
        //[1]초기식
        int i = 4;

        do
        {
            //반복 실행문
            Debug.Log("안녕하세요");

            //[2]증감식
            i++;
        } while (i < 3);   //[3]조건식

        //i:0 => 출력 => i:1 => i<3 (참) => 출력 => i:2 => i<3 (참) => 출력
        //i:3 => i<3 (거짓) =>  dowhile 종료

    }
}

/*
doWhile 문 - 반복문
먼저 반복 실행문 1번 실행한다
조건식이 true이면 반복문을 실행한다
조건식이 false이면 while문 종료한다

do
{
    //반복 실행문

} while (조건식)

*/