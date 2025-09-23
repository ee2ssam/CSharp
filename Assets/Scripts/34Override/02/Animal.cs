using UnityEngine;

namespace MethodOverride
{
    //부모클래스
    public class Animal
    {
        //virtual 이 표시된 메서드 : 상속받은 자식클래스가 재정의 사용시 override 키워드 사용하라
        public virtual void Eat() => Debug.Log("Animal Eat");
    }

    //자식클래스
    public class Dog : Animal
    {
        //virtual 메서드 재정의 -> override 키워드 사용
        public override void Eat()
        {
            Debug.Log("강아지가 밥을 먹는다");
        }
    }
}
