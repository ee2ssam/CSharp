using UnityEngine;

namespace InheritanceProtectedTest
{
    //자식클래스 선언
    public class ChildClass : ParentClass // :(콜론) 기호로 부모클래스 지정
    {
        //protected 상속 받은 자식클래스(코드 블록안)에서만 접근 가능
        public void PrintMessage2()
        {
            //자식 클래스 코드 블록 안에서 부모의 멤버에 접근 방법 : base 키워드 사용
            base.PrintMessage();

            Debug.Log("자식클래스에서 정의한 내용");
        }
    }
}

