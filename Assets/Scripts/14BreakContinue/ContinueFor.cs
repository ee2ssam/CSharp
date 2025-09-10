using UnityEngine;

public class ContinueFor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //1부터 5까지 홀수만 출력하는 프로그램 구현
        /*for (int i = 1; i <= 5; i++)
        {
            if(i % 2 != 0)    //홀수 판별식
            {
                Debug.Log(i);
            }
        }*/

        for (int i = 1; i <= 5; i++)
        {
            //짝수이면 건너뛰기
            if(i % 2 == 0)
            {
                continue;   //현재 반복 실행중인 반복문을 중지하고 다음 반복문으로 이동
            }

            //반복 실행문
            Debug.Log(i);
        }
    }
}

/*
continue;
반복문(for, while)에서 continue; 문을 만나면 
continue; 문 아래 명령문들을 실행하지 않고
다음 반복문의 조건을 체크하러 간다
반복문 참이면 반복 실행문을 실행하고 거짓이면 종료한다
*/