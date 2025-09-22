using UnityEngine;

namespace AbstractMustTest
{
    //추상 클래스 - 상속 받는 자식 클래스에게 지정한 기능을 구현하도록 강제한다    
    public abstract class GeneralManager
    {
        //추상 메서드 선언 - 지정한 기능, 메서드 구현부분(본문, 코드블록 부분) 생략
        public abstract void SayTalk();
    }
}

