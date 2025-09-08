using UnityEngine;

// ElseIf 문
// 두개의 정수 number1, number2 를 입력받아
// [1] number1이 크면 number1이 큽니다 출력
// [2] number2이 크면 number2가 큽니다 출력
// [3] 나머지는 두수의 크기가 같습니다 출력
public class IfElseIfElse : MonoBehaviour
{
    //두개의 변수 선언하고 0으로 초기화
    //[1]선언문
    public int number1 = 0;
    public int number2 = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //두개의 수 중 큰 수 찾기
        //[1] number1이 크면
        if(number1 >  number2)
        {
            //실행문1
            Debug.Log("number1이 더 큽니다");
        }
        else if(number2 > number1) //[2] number2이 크면
        {
            //실행문2
            Debug.Log("number2가 더 큽니다");
        }
        else // [1]도 아니고 [2]도 아니면
        {
            //실행문3
            Debug.Log("두수의 크기가 같습니다");
        }

        //실행문4
    }
}

/*
//[1] number1이 크면 - 조건식 1이 참이면
선언문 - 실행문1 - 실행문4
//[2] number2이 크면 - 조건식 1이 거짓이고 조건식 2가 참이면
선언문 - 실행문2 - 실행문4
//[3] 조건식 1 거짓이고 조건식 2 거짓이면
선언문 - 실행문3 - 실행문4

//[4] 조건식 1이 참이고 조건식 2도 참이면
선언문 - 실행문1 - 실행문4

*/
