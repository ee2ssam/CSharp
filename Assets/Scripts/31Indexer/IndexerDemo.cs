using UnityEngine;

namespace Indexer
{
    public class IndexerDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Catalog 클래스의 인스턴스를 생성
            Catalog ca = new Catalog();
            //인덱서 호출: 인스턴스이름[인덱스]
            Debug.Log(ca[0]);
            Debug.Log(ca[1]);
            Debug.Log(ca[2]);
            Debug.Log(ca[3]);
            Debug.Log(ca[4]);

        }
    }

    public class Catalog
    {
        //인덱서 정의
        public string this[int index]
        {
            get
            {
                return (index % 2 == 0) ? $"{index}:짝수" : $"{index}:홀수";
            }
        }
    }
}


/*
Indexer(인덱서) : 클래스의 인스턴스(객체)를 배열처럼 [] 를 사용할 수 있도록 해주는 구문
               : 인스턴스이름[0], 인스턴스이름[1], 인스턴스이름[2]
               : 클래스(맴버중 배열, 컬렉션)의 값을 인덱서로 호출해서 사용(읽기, 쓰기)가 가능하게 한다

: 실제 인스턴스의 배열이라면 사용은 인스턴스이름[0].멤버이름로 사용

인덱스 형식
Class car
{
}
Car cars = new Car(3);
cars[0] = "a";
cars[1] = "b";
cars[2] = "c";
*/