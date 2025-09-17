using UnityEngine;

namespace Constructor
{
    public class Dog
    {
        //[1]필드
        private string name;

        //[2]생성자: 필드의 초기값 설정
        public Dog(string value)
        {
            //매개변수로 값을 받아서 name 필드 초기화
            name = value;
        }

        //[3]메서드
        public string Cry()
        {
            return name + "이(가) 멍멍멍";
        }

    }
}