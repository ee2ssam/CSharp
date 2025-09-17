using UnityEngine;

namespace Field
{
    public class StaticDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Truck 클래스의 정적(static) 멤버 사용하기
            //클래스이름.정적멤버이름 으로 접근해서 사용한다
            Truck.name = "홍길동";
            string tName = Truck.GetName();
            Debug.Log(tName);

            //Truck.age = 20; (x)

            //Truck 클래스의 인스턴스(instance) 멤버 사용하기
            //Truck 클래스의 인스턴스(instance) 생성
            //생성된 인스턴스(instance)이름.인스턴스멤버이름 으로 접근해서 사용
            Truck truck = new Truck();
            //truck.age = 20; (보호수준 에러, private)
            truck.SetAge(20);
            Debug.Log(truck.GetAge());

        }
    }
}