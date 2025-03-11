using UnityEngine;

//전역 변수, 지역변수
public class FunctionScope : MonoBehaviour
{
    string message = "전역 변수";   //필드, 멤버 변수


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ShowMessage();

        PrintMessage();
        Debug.Log(message);
    }

    //message를 출력하는 함수
    void ShowMessage()
    {
        string message = "지역 변수";
        Debug.Log(message);
    }

    void PrintMessage()
    {
        Debug.Log(message);
    }

}
