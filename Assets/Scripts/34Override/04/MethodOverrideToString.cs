using UnityEngine;

namespace MethodOverride
{
    public class MethodOverrideToString : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Person 클래스의 인스턴스 만들기
            Person person = new Person("홍길동");

            //객체를 문자열로 출력하면 ToString() 호출된다
            Debug.Log(person);
        }
    }
}