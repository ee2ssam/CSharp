using UnityEngine;

namespace Property
{
    public class PropertyAutomatic : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Truc 클래스의 인스턴스 생성
            Truck truck1 = new Truck();
            truck1.Name = "제네시스";
            Debug.Log(truck1.Name);

            Truck truck2 = new Truck();
            truck2.Name = "그랜저";
            truck2.Color = "Red";
            Debug.Log($"옆집 트럭: {truck2.Name}, {truck2.Color}");
        }

    }
}