using UnityEngine;

public class ConstantNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //변수 선언하고 초기화
        string name = "홍길동";
        name = "이순신";         //수정 가능

        //상수 선언하고 초기화
        const int AGE = 20;     //age 20으로 고정
        //AGE = 21;             //age 수정시 에러 발생

        //사용
        Debug.Log($"{name} - {AGE}");
    }
}

/*
클래스 이름 : 첫 알파벳 글자는 대문자, 단어와 단어 연결시 다음 단어의 첫글자는 대문자
변수 이름 : 첫 알파벳 글자는 소문자, 단어와 단어 연결시 다음 단어의 첫글자는 대문자
상수 이름 : 모두 대문자


*/
