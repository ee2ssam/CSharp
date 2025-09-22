using UnityEngine;

namespace AbstractMustTest
{
    //추상 클래스를 상속 받는 자식 클래스
    //추상 클래스가 지정하는 기능을 구현한다
    public class Person : GeneralManager
    {
        //상속받은 추상 메서드 구현
        public override void SayTalk()
        {
            Debug.Log("상속 받은 추상 메서드를 구현한다");
        }
    }
}

/*
//추상 클래스가 지정하는 기능을 구현해야 한다
//상속 받은 추상클래스의 추상 메서드 구현하기
public override void 추상메서드이름 ()
{

}
*/