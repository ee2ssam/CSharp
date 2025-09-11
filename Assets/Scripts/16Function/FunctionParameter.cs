using UnityEngine;

//매개변수(Parameter)가 있는 함수 만들고 호출하기
public class FunctionParameter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2]매개변수가 있는 함수 호출하기
        ShowMessage("매개 변수");
        ShowMessage("안녕하세요");
    }

    //[1]매개변수(Parameter)가 있는 함수 선언하기
    //매개변수를 통해 들어온 문자열을 출력하기
    void ShowMessage(string message)
    {
        Debug.Log(message);
    }
}
