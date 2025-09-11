using UnityEngine;

public class FunctionOverload : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //인사하기
        MultiHi();

        MultiHi("반갑습니다");

        MultiHi("또 만나요", 3);
    }

    //인사하는 함수 만들기
    //매개변수가 없는 함수 Hi()
    void MultiHi()
    {
        Debug.Log("안녕하세요");
    }

    //매개변수(string msg)가 있는 함수 Hi()
    void MultiHi(string msg)
    {
        Debug.Log(msg);
    }

    //매개변수(string, int count)로 인사하는 횟수 받아서 반복 인사하는 Hi()
    void MultiHi(string msg, int count)
    {
        for (int i = 0; i < count; i++)
        {
            Debug.Log(msg);
        }
    }

}
