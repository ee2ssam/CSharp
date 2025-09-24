using UnityEngine;

namespace Oop
{
    //캡슐화: 필드는 기본적으로 private 으로 외부에 노출하지 않는다
    public class Person
    {
        //[1]필드
        private string name;

        //[2]메서드 : public한 메서드(또는 속성)로 private한 필드를 외부에 공개할 수 있다
        public void SetName(string name) => this.name = name;
        public string GetName() => this.name;  
    }


    public class OopDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Person person = new Person();
            //캡슐화
            person.SetName("홍길동");
            Debug.Log(person.GetName());
        }
    }
}

/*
객체(개체) 지향 프로그래밍을 하기 위해 class를 배웠다
객체(개체) 지향 프로그래밍 4가지 특성, 개념 
- 상속
- 캡슐화
- 다형성
- 추상화
*/