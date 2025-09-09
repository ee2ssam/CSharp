using UnityEngine;

public class WhileCountdown : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //1부터 5까지 Countdown 프로그램 구현
        //[1]초기식
        int i = 1;

        while(i <= 5) //[2]조건식
        {
            //반복 실행문
            Debug.Log($"증가 카운트 다운: {i}");

            //증감식
            i++;
        }

        Debug.Log("=========================================");
        //5부터 1까지 Countdown 프로그램 구현
        //[1] 초기식
        int j = 5;

        while(j >= 1)   //[2]조건식
        {
            //반복 실행문
            Debug.Log($"감소 카운트 다운: {j}");

            //[3]증감식
            j--;
        }


    }
}
