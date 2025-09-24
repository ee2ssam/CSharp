using UnityEngine;

namespace Genenric
{
    public class Water { }

    public class Coffee { }

    //클래스이름<T> 형태로 제네릭 클래스 선언
    public class Cup<T>
    {
        //T타입의 속성 멤버
        public T Content { get; set; }
    }
}

