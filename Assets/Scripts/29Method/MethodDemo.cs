using UnityEngine;

namespace Method
{
    public class MethodDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Rectangle 클래스의 인스턴스를 생성
            Rectangle rect = new Rectangle();
            Debug.Log(rect.GetName());
        }
    }

    public class Rectangle
    {
        //메서드
        public string GetName()
        {
            return "정사각형";
        }
    }
}

/*
메서드(Method), 함수(function) 
: 클래스가 수행할 수 있는 기능들을 각각 다른 이름으로 묶어 관리(구현)하는 코드 블록

접근제한자       정적      반환타입
public(private) static(x) void(int, string ...) 메서드이름 (매개변수)
{
    //메서드의 실행문들..

    //return 반환타입
}

메서드 이름
: 이름의 첫 글자는 대문자로 쓴다
: 동사 + 명사
~를 읽는다 : GetName, GetHp, GetMoeny
를 쓰기 : SetName("홍길동")
*/

