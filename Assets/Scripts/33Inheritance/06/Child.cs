using UnityEngine;

namespace InheritanceConstructorTest
{
    //자식 클래스 선언
    public class Child : Parent
    {
        //생성자
        public Child() : this("안녕하세요")
        {
            Debug.Log("자식의 기본 생성자 실행");
        }

        public Child(string message) : base(message)
        {

        }

        //메서드
        public void SayHello()
        {
            Debug.Log(base.Word);
        }
    }
}