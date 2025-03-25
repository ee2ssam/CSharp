using UnityEngine;

namespace GenericClass
{
    //제네릭 클래스 만들기 - 설계
    public class Hello<T>
    {
        //필드
        private T _message;

        //생성자
        public Hello()
        {
            this._message = default(T);
        }
        public Hello(T message)
        {
            this._message = message;
        }

        //메서드
        public void Say(T messeage)
        {
            Debug.Log($"{messeage}");
        }

        public T GetMessage() => this._message;
    }
}
