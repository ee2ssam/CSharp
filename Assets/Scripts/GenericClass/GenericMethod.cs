using UnityEngine;

namespace GenericClass
{
    public class GenericMethod : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Hello(제네릭) 클래스 인스턴스 생성
            Hello<int> hi = new Hello<int>();
            hi.Say(1234);

            Hello<string> hs = new Hello<string>("안녕하세요");
            hs.Say(hs.GetMessage());
        }
    }
}