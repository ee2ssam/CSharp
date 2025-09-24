using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Genenric
{
    //고객정보를 관리하는 클래스
    public class Person
    {
        public string Name { get; set; }
        //...
    }


    public class GenericCollection : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //고객<전용> 리스트 선언 및 초기화
            List<Person> people = new List<Person>
            {
                new Person { Name = "홍길동" },
                new Person { Name = "백두산" },
                new Person { Name = "임꺽정" },
            };

            //리스트 사용
            foreach (var person in people)
            {
                Debug.Log(person.Name);
            }
        }
    }
}

/*
제네릭 클래스 : 형식 매개변수 T로 지정한 형식으로 클래스와 멤버의 성질이 결정되는 클래스
Generic Class : Cup<T> 컵어브티, 전용컵
*/