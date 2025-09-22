using UnityEngine;

namespace InheritanceBaseTest
{
    //부모 클래스
    public class Car
    {
        //필드
        private string name;

        //생성자 - 매개변수를 입력 받아 필드(name) 초기화
        public Car(string _name)
        {
            this.name = _name;
        }

        //메서드
        public void Run()
        {
            Debug.Log($"{this.name}가 달린다");
        }
        
    }
}