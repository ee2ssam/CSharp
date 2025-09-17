using UnityEngine;

namespace Field
{
    public class Truck
    {
        //필드 선언
        //정적(static) 멤버 변수 선언 및 초기화
        public static string name = "트럭";
        //인스턴스(instance) 멤버 변수 선언
        private int age;

        //정적(static) 멤버 함수, 메서드 : 인스턴스 멤버는 바로 사용하지 못한다
        public static string GetName()
        {            
            return name;
        }

        //인스턴스(instance) 멤버 함수, 메서드
        public void SetAge(int value)
        {
            age = value;
        }

        public int GetAge()
        {
            return age;
        }
    }
}