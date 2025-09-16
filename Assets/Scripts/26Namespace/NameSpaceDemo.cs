using UnityEngine;
using Bar;
using Foo;

public class NameSpaceDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Car car = new Car();

        //[1] Bar 네임스페이스 Car 클래스 인스턴스 생성
        Bar.Car barCar = new Bar.Car();
        barCar.Go();

        //[2] Foo 네임스페이스 Car 클래스 인스턴스 생성
        Foo.Car fooCar = new Foo.Car();
        fooCar.Go();
    }
}

/*
NameSpace(네임스페이스)
: 클래스 등의 사용자 정의 형식들의 이름 충돌 방지
: 클래스 등을 관련 기능끼리 묶어서 관리

: 네임스페이스 이름은 맨 앞 철자는 대문자로 한다
namespace 네임스페이스 이름
{


}
*/


