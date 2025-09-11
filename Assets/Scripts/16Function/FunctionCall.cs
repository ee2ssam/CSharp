using UnityEngine;

public class FunctionCall : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2]함수 사용(호출) - 3번 호출
        Hi();
        Hi();
        Hi();
    }

    //[1]함수 선언,정의
    //인사하는 함수
    void Hi()
    {
        Debug.Log("안녕하세요");
    }
}
