using UnityEngine;

//Generic Class(제네릭 클래스)
//:형식 매개변수 T에 지정한 형식으로 클래스와 멤버의 성질이 결정되는 클래스
// Cup<T> : 컵어브티, 전용 컵
namespace GenericClass
{
    public class Water { }

    public class Coffee { }

    //제네릭 클래스 만들기 - 클레스이름<T>
    public class Cup<T>
    {
        public T Content { get; set; }

        //public Water Content { get; set; }
        //public int Content { get; set; }
        //public string Content { get; set; }

        //매개변수로 입력받은 T형식의 데이터를 출력하라
        public void PrintData(T data)
        {
            Debug.Log($"{data}");
        }
    }
}
