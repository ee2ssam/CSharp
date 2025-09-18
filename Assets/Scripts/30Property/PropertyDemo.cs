using UnityEngine;

namespace Property
{
    public class PropertyDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[1] Developer 클래스의 인스턴스 생성
            Developer dev = new Developer();

            //[2] 속성에 값을 설정
            dev.Name = "홍길동";

            //[3] 속성값 사용
            Debug.Log(dev.Name);

        }
    }

    //속성 예제
    public class Developer
    {
        //속성 만들기
        public string Name { get; set; }
    }
}

/*
속성(Property) : 필드의 값을 읽거나 쓰거나 연산하는 방법을 제공하는 클래스 멤버
                필드의 접근제한자의 기본은 private(외부에서 접근이 안된다)
                속성은 제한 필드를 외부에서 읽거나 쓰기가 가능하도록 해준다

: 속성이름의 맨 앞글자는 대문자로 사용한다
: 속성의 사용방법은 변수와 동일하다

기본 형식
public [반환타입] 속성이름 { get; set; }
*/