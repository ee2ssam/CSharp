using UnityEngine;

public class MethodOverloadDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Hi();
        Hi("반갑습니다");
        Hi("감사합니다", 3);
    }

    //인사하는 함수 구현하기 : Hi
    //매개변수가 없는 함수
    void Hi()
    {
        Debug.Log("안녕하세요");
    }

    //매개변수로 입력받은 (message)로 인사
    void Hi(string message)
    {
        Debug.Log(message);
    }

    //매개변수로 입력받은 (message)를 매개변수로 받은 (count) 횟수 만큼 인사
    void Hi(string message, int count)
    {
        for (int i = 0; i < count; i++)
        {
            Debug.Log(message);
        }
    }

}
