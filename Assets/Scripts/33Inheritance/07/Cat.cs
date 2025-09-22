using UnityEngine;

namespace InheritanceSealedTest
{
    //자식 클래스 선언
    //sealed(봉인) 클래스 지정 (최종 클래스): 상속 거부, 더이상 상속이 안된다
    sealed public class Cat : Animal
    {

    }


    //자식의 자식 클래스 선언
    //Cat 클래스를 부모로 지정해서 Cat 클래스에 있는 기능을 모두 가져와서 사용
    /*public class MyCat : Cat
    {
        //sealed 붙은 클래스는 부모로 지정이 불가능
    }*/
}
