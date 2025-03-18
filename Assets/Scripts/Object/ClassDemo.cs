using UnityEngine;

//ClassOne, ClassTwo 클래스를 사용
public class ClassDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //다른 클래스의 멤버 호출
        //[1] static 멤버 호출
        ClassOne.Hi();  //안녕하세요 출력
        ClassTwo.Hi();  //반갑습니다 출력

        //[2] instance 멤버 호출
        //다른 클래스의 인스턴스(개체, 객체) 생성
        ClassTwo two = new ClassTwo();
        two.Hello();

    }
}
