using UnityEngine;

namespace Constructor
{
    public class ConstructorDescription : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Person 클래스의 인스턴스 생성
            //[1]매개변수가 없는 기본 생성자 호출
            Person saram1 = new Person();
            Debug.Log(saram1.GetName());

            //다른 사람2 saram2
            Person saram2 = new Person();
            Debug.Log(saram2.GetName());

            //[2]매개 변수가 있는 생성자 호출
            Person person1 = new Person("백두산");
            Debug.Log(person1.GetName());

            //다른 퍼슨2, person2 
            Person person2 = new Person("장길산");
            Debug.Log(person2.GetName());

        }
    }
}