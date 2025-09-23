using UnityEngine;

namespace InterfaceDemoTest
{
    //인터페이스 선언, 정의
    //자동차를 구현하기 위해 필요한 기능들을 정의한 인터페이스
    public interface ICar
    {
        //클래스에서 구현해야 하는 관련 기능들에 대한 정의
        //메서드의 반환형과 이름만 제공
        void Go();

        //전진, 후진, 좌회전, 우회전, 브레이크, 변속..

        /*public void Do()
        {
            Debug.Log("인터페이스에서는 구현이 안됨");
        }*/
    }
}