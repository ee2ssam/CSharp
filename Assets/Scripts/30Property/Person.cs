using UnityEngine;

namespace Property
{
    public class Person
    {
        //필드
        private string name;    //이름

        //public [반환타입] 속성이름 { get; set; }
        //필드의 값을 읽거나 쓰거나 연산하는 방법을 제공하는 클래스 멤버
        //속성(property)를 이용해서 name에 접근 사용
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //private한 필드를 public한 메서드를 이용하여 쓰고 읽는다
        public void SetName(string _name)
        {
            name = _name;
        }

        public string GetName()
        {
            return name;
        }
    }
}
