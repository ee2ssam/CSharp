using UnityEngine;

namespace InterfaceDemoTest
{
    // ICar 인터페이스를 상속받는 Car 클래스 선언
    public class Car : ICar
    {
        public void Go()
        {
            Debug.Log("상속한 인터페이스에 정의된 모든 멤버를 반드시 구현해야 한다");
        }
    }
}