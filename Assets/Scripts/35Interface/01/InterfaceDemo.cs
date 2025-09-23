using UnityEngine;

namespace InterfaceDemoTest
{
    public class InterfaceDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Car클래스의 인스턴스 생성
            var car = new Car();
            car.Go();
        }
    }
}


/*
인터페이스(Interface)
: 클래스에서 구현해야 하는 관련 기능에 대한 정의가 포함된 개념
: 특정 멤버(지정하는 기능)가 반드시 구현되어야 함을 보증
: 인터페이스를 상속받는 클래스는 인터페이스가 지정하는 기능을 구현 하도록 강제한다

: 인터페이스 이름 : 맨 앞 문자는 대문자 'I' 로 시작한다

형태
public interface 인터페이스이름
{
    //클래스에서 구현해야 하는 관련 기능들에 대한 정의
    //메서드 기능 정의
    //메서드 구현부분(본문, 코드블록 부분) 생략
}
*/