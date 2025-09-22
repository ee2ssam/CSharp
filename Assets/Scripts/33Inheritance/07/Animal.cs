using UnityEngine;

namespace InheritanceSealedTest
{
    //부모 클래스
    public class Animal : System.Object
    {
        //메서드
        public void Eat()
        {
            Debug.Log("밥을 먹습니다");
        }
    }
}