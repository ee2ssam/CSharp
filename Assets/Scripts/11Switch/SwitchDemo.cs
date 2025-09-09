using UnityEngine;

public class SwitchDemo : MonoBehaviour
{
    //[1] 변수 선언
    public int x = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //switch(조건)
        switch(x)
        {
            case 1:
                Debug.Log("x는 1입니다"); //실행문[2]
                break;

            case 2:
                Debug.Log("x는 2입니다"); //실행문[3]
                break;
        }

        //실행문[4]
        Debug.Log("프로그램 종료");

        //x=2; [1] -> [3] -> [4]
        //x=1; [1] -> [2] -> [4]
        //x=3; [1] -> [4]

    }
}


/*
if(조건식) : 참, 거짓 판별
{
    실행문 1 - 참일때 실행
}
else
{
    실행문 2 - 거짓일때 실행
}

switch(조건) : Data 값 판별
{
    case 1번:
        //실행문 1
        break;

    case 2번:
        //실행문 2
        break;

    case 3번:
        //실행문 3
        break;

    default:    //모든 경우가 아니면
        //실행문 4
        break;
}

*/
