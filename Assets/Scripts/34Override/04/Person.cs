using UnityEngine;

namespace MethodOverride
{
    public class Person
    {
        //필드
        private string name;    //객체 이름

        //생성자 : 생성시 매개변수로 객체이름을 입력 받아 저장한다
        public Person(string name)
        {
            this.name = name;
        }

        // ToString() 메서드 오버라이드
        public override string ToString()
        {
            return $"Person 클래스: {this.name}";
        }
    }
}
