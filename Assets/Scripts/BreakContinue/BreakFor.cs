using UnityEngine;

// break; : 반복문(for, while)에서 { } 을 빠져나오는 명령문
// 반복문 안에서 break;문을 만나면 즉시 반복문을 강제 종료 한다
public class BreakFor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //안녕하세요를 5번 출력하는 프로그램
        //i = 2일때 for문 종료
        for(int i = 0; i < 5; i++)
        {
            //반복 실행문
            Debug.Log("안녕하세요");

            if (i == 2)
            {
                break;
            }
        }

        // i:0 => i<5(참) => 출력 => i==2(거짓) => i:1 => i<5(참) => 출력
        // i==2(거짓) => i:2 => i<5(참) => 출력 => i==2(참) => break; => for문 종료

    }
}
