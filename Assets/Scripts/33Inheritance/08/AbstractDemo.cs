using UnityEngine;
using AbstractDemoTest;

namespace Inheritance
{
    public class AbstractDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //부모 클래스의 인스턴스(객체) 생성
            //ParentClass parent = new ParentClass();   //추상 클래스는 인스턴스 생성 불가

            ChildClass child = new ChildClass() { Id = 1, Active = true, Name = "홍길동" };
            if (child.Active == true)
            {
                Debug.Log($"{child.Id} - {child.Name}");
            }
        }
    }
}


/*
abstract Class (추상 클래스)
: 자신을 상속 받은 자식 클래스에게 강제로 기능을 추가하도록 한다
: 자식 클래스가 지정한 기능을 구현하도록 강제한다
: 추상 클래스는 인스턴스(객체)를 만들수 없다
: 추상 클래스는 다른 클래스의 부모 클래스로만 사용이 가능

구성 형태
public abstract class 추상클래스이름
{


}


: 자식 클래스에게 지정한 기능을 구현하도록 강제한다

추상 메서드 : 지정한 기능(메서드)
           : 메서드 구현부분(본문, 코드블록 부분) 생략

추상 메서드 구성 형태
public abstract void (추상메서드이름) ();
*/
