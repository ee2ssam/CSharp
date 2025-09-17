using UnityEngine;

namespace Field
{
    public class FieldDemo : MonoBehaviour
    {
        //[1]필드, 전역변수(멤버변수) 선언 및 초기화
        string globalVariable = "전역 변수";

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[2]지역변수 선언하고 초기화
            string loaclVariable = "지역변수";

            //지역변수  사용
            Debug.Log(loaclVariable);

            //전역변수 사용
            Debug.Log(globalVariable);

            TestPrint();
        }

        //
        void TestPrint()
        {
            //지역변수  사용
            //Debug.Log(loaclVariable); //error

            //전역변수 사용
            Debug.Log(globalVariable);
        }

        //두수를 더해서 출력하는 함수
        void Sum()
        {
            //지역변수 선언 및 초기화
            int i = 1234;
            int j = 5678;

            //지역변수 사용
            Debug.Log(i + j);
        }
    }
}


/*
Variable(변수)
: 지역변수(local variable)
: 전역변수(global variable)

Field(필드) : 클래스 안에서 선언된 전역 변수(global variable), 멤버 변수
: 클래스의 부품, 클래스의 내부 상태(속성) 값을 저장하는 그릇

필드 네이밍: 맨 앞 첫 문자를 소문자 알파벳으로 한다
: m_name, 소문자 알파벳으로 시작하고 다음 단어를 시작할때 대문자 사용
: 상수, 읽기 전용 변수의 첫 알파벳은 대문자로 시작한다 (ex MAX)

액세스 한정자(접근 제한자)
- public : 접근의 제한이 없다
- private : 해당(현재) 클래스안에서만 접근이 가능하다 
- protected : 해당(현재) 클래스안에서만 접근이 가능하다, 상속받은 자식 클래스에서 접근 가능
- internal, protected internal : 해당 프로젝트 내에서 접근 가능
*/