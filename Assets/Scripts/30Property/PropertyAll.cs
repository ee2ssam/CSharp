using UnityEngine;

namespace Property
{
    public class PropertyAll : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Car클래스 인스턴스 생성

            //[1]Get,Set 메서드 이용 - 빨간색 자동차
            Car car1 = new Car();
            car1.SetColor("Red");
            Debug.Log(car1.GetColor());

            //[2] 속성을 이용 - 흰색 자동차
            Car car2 = new Car();
            car2.Color = "White";
            Debug.Log(car2.Color);

            //[3] 읽기 전용
            Car car3 = new Car();
            //car3.Maker = "기아자동차"; //읽기 전용으로 쓰기 불가
            Debug.Log(car3.Maker);

            //[4] 축약형 속성
            Car myCar = new Car();
            myCar.Name = "붐붐";
            Debug.Log(myCar.Name);  

        }
    }
}