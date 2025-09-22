using UnityEngine;
using InheritanceDemoTest;

namespace Inheritance
{
    public class InheritanceDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //자식(Child) 클래스의 인스턴스 생성
            Child child = new Child();

            //자식 클래스의 멤버 메서드 호출
            child.Bar();

            //부모 클래스의 멤버 메서드 호출
            child.Foo();

        }
    }
}

/*
Inheritance(상속) 
: 부모클래스가 자신의 기능 등을 자식 클래스에게 물려주어서 사용하도록 해준다

부모클래스 : 슈퍼클래스, Base(베이스)클래스, 기본 클래스
: 부모는 자식 클래스를 여러개 가질수 있다
: 자식 클래스들의 공통 기능을 모아 놓은 클래스가 부모 클래스

자식클래스 : Sub(서브) 클래스
//자식클래스 선언 : 자식 클래스가 부모클래스를 지정하면 부모클래스의 기능을 모두 사용할수 있다
public class 자식클래스이름 : 부모클래스 이름

손자클래스 : 자식 클래스의 자식 클래스
: 부모클래스와 자식 클래스의 모든 기능을 물려받는다


*/