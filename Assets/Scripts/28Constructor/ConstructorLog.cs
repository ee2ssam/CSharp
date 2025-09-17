using UnityEngine;

namespace Constructor
{
    public class ConstructorLog
    {
        //기본 생성자
        public ConstructorLog()
        {
            Debug.Log("기본 생성자 실행");
        }

        //매개변수 string 이 있는 생성자
        public ConstructorLog(string message)
        {
            Debug.Log($"오버로드 된 생성자 실행: {message}");
        }

        //...
    }
}

/*
생성자 Overload : 함수의 다중 정의
: 동일한 이름의 생성자를 매개변수를 달리해서 여러개 생성(정의)
*/