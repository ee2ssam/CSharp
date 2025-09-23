using UnityEngine;

namespace InterfaceDemoTest
{
    //강아지를 관리하는 클래스
    //인터페이스는 다중 상속이 가능, 클래스는 다중 상속이 불가능
    public class Dog : IAnimal, IDog
    {
        //IAnimal 인터페이스 기능 구현
        public void Eat()
        {
            Debug.Log("먹다");
        }

        //IDog 인터페이스 기능 구현
        public void Yelp()
        {
            Debug.Log("짖다");
        }
    }
}
