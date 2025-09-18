using UnityEngine;

namespace Method
{
    public class MethodPublicPrivate : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Dog 클래스 인스턴스(객체) 생성
            Dog cat = new Dog();

            //인스턴스 메서드 사용방법
            //인스턴스이름.(public)함수이름 으로 호출
            cat.Eat();  // public 메서드 사용(호출) 가능
            //cat.Digest(); //private 메서드 사용(호출) 불가능 (보호수준 때문에)

            //정적(static) 함수의 사용 방법
            //클래스이름.정적함수이름 이름으로 호출
            Dog.Drink();
        }
    }
}