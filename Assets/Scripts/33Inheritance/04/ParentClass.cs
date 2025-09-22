using UnityEngine;

namespace InheritanceProtectedTest
{
    //부모 클래스
    public class ParentClass : System.Object //모든 클래스 Object 클래스로부터 상속 받는다
    {
        //부모 클래스 코드 블록안에서는 private 과 같은 기능을 한다
        //protected 상속 받은 자식클래스(코드 블록안)에서만 접근 가능
        protected void PrintMessage()
        {
            Debug.Log("부모클래스에서 (protected)정의한 내용");
        }
    }
}