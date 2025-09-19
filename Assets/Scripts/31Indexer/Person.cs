using UnityEngine;

namespace Indexer
{
    public class Person
    {
        //필드
        private string name;

        //인덱서 구현 - 인덱스 번호와 상관 없이 name 필드의 값을 읽고 쓰는 인덱서
        public string this[int index]
        {
            get { return name; }    //인스턴스이름[인덱스] 호출하면 name 필드값을 반환
            set { name = value; }   //인스턴스이름[인덱스] 호출해서 name 필드 값에 저장
        }
    }
}