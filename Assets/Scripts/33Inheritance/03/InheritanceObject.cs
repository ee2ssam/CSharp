using UnityEngine;
using InheritanceObejctTest;

namespace Inheritance
{
    public class InheritanceObject : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //부모클래스의 인스턴스(객체) 생성
            Parent pa = new Parent();
            //pa.Hi();
            Debug.Log(pa.ToString());

            //자식 클래스의 인스턴스(객체) 생성
            Child ch = new Child();
            Debug.Log(ch.ToString());

            //static 메서드 : (클래스이름).(메서드이름)
            Parent.Hi();

            Child.Hi();
            Child.Hello();

        }
    }
}