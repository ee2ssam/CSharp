using UnityEngine;

namespace InheritanceDemoTest
{
    //자식클래스 선언 : 부모클래스 이름
    public class Child : Parent
    {
        public void Bar()
        {
            Debug.Log("자식 클래스의 멤버 호출");
        }
    }
}