using UnityEngine;

public class NullDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //값 형식
        int i = 0;

        //참조 형식
        string s = null;
        s = "안녕하세요";

        string empty = "";
    }
}

/*
Null ( NULL, null)
:아무것도 없는 상태, 아무것도 없음을 의미하는 리터널
:인스턴스(객체)가 아무것도 참조하지 않음, null 참조

(값 형식) x  1234
(참조 형식) s  ---------> "안녕하세요"
(참조 형식) o  
참조형 변수(o)에 아무런 값도 설정하지 않음, null 참조
string의 ""(빈값, empty) 과 null은 다름
*/
