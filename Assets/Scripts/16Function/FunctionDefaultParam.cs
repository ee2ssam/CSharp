using UnityEngine;

// 기본 매개변수(Default Parameter) : 매개변수 선언시 초기화 한다
public class FunctionDefaultParam : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //메세지 출력 함수 호출
        /*PrintMessage();

        string errorLog = PrintLog();
        Debug.Log(errorLog);*/

        //디폴트 파라미터
        PrintError("에러 메세지", 4);
        PrintError("에러 메시지");

    }

    //메세지를 출력하는 함수
    void PrintMessage()
    {
        string msg = "디버그";
        Debug.Log(msg);
    }

    void PrintError(string message, int level = 1)
    {
        Debug.Log($"{message} : 레벨 {level}");
    }

    string PrintLog()
    {
        string log = "로그";
        return log;
    }

}
