using UnityEngine;


public class FunctionReturn : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2]반환값이 있는 함수 호출
        //반환하는 데이터 타입과 동일한 변수를 선언하여 반환되는 값을 저장
        string retrunValue = GetString();
        Debug.Log(retrunValue);
    }

    //[1]반환값(Return Value)이 있는 함수 선언
    //"반환값(Return Value)" 문자열을 반환하는 함수
    string GetString()
    {
        //return 키워드 뒤에는 함수 선언문에 있는 데이터 타입과 동일한 변수, 값이 와야 한다
        return "반환값(Return Value)"; 
    }
}
