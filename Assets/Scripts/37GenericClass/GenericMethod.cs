using UnityEngine;

namespace Genenric
{
    public class GenericMethod : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Hello<T> 제네릭 클래스 인스턴스 생성
            Hello<int> hi = new Hello<int>();
            Debug.Log(hi.GetMessage());
            hi.Say(1234);

            Hello<string> hello = new Hello<string>("안녕하세요");
            Debug.Log(hello.GetMessage());
            hello.Say("반갑습니다");

        }
    }
}