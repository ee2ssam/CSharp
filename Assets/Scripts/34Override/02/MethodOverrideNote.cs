using UnityEngine;

namespace MethodOverride
{
    public class MethodOverrideNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //부모 클래스의 인스턴스 생성
            Animal animal = new Animal();
            animal.Eat();

            //자식 클래스의 인스턴스 생성
            Dog dog = new Dog();
            dog.Eat();

            //다형성
            //부모 클래스의 객체를 자식 인스턴스로 생성
            Animal happy = new Dog();
            happy.Eat();


        }
    }
}