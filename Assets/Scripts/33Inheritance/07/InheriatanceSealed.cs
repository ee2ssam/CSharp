using UnityEngine;
using InheritanceSealedTest;

namespace Inheritance
{
    public class InheriatanceSealed : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //자식 클래스 생성
            Cat cat = new Cat();
            cat.Eat();
        }
    }
}