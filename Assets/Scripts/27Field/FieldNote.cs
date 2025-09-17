using UnityEngine;

namespace Field
{
    public class FieldNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Person 클래스의 인스턴스 생성
            Person person = new Person();
            //person 인스턴스(객체)를 이용해서 Person 클래스에 있는 public 멤버에 접근해서 사용
            person.ShowProfile();
        }
    }
}