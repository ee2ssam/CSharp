using UnityEngine;

namespace InheritanceConstructorTest
{
    //부모 클래스
    public class Parent
    {
        //속성(property)
        public string Word { get; set; }

        //생성자 - 매개변수를 입력 받아 속성 초기화
        public Parent(string word)
        {
            this.Word = word;
        }

    }
}