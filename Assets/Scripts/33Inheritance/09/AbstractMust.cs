using UnityEngine;
using AbstractMustTest;

namespace Inheritance
{
    public class AbstractMust : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //자식 클래스의 인스턴스(객체) 생성
            Person person = new Person();
            person.SayTalk();
        }
    }
}