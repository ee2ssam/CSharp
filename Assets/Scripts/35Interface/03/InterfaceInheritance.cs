using UnityEngine;

namespace InterfaceDemoTest
{
    public class InterfaceInheritance : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Dog 클래스 인스턴스 생성
            Dog dog = new Dog();
            dog.Eat();  //IAnimal 인터페이스 기능 구현 후 호출
            dog.Yelp(); //IDog 인터페이스 기능 구현 후 호출
        }
    }
}