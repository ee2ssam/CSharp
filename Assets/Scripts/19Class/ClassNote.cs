using UnityEngine;

//정적(static) 메서드, 인스턴스(Instance) 메서드
public class ClassNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 정적(static) 메서드 호출 : 클래스이름.메서드이름()
        ClassMember.StaticMethod();

        //[2] 인스턴스(Instance) 메서드 호출
        //클래스의 객체(개체, Instance) 생성 - 클래스 변수 선언
        //new 키워드로 새로운 개체 생성
        //(클래스 이름) (개체 이름) = new 클래스 이름();
        //(개체 이름).메서드이름(), (개체 이름).변수이름
        ClassMember member = new ClassMember();
        member.InstanceMethod();

    }
}
