using UnityEngine;

namespace Field
{
    public class Person
    {
        //필드 선언
        //[1] 변수 형식의 필드
        private string name = "홍길동";
        //[2] 상수 형식의 필드
        private const int AGE = 20;
        //[3] 읽기 전용 형식의 필드
        private readonly string NickName = "도깨비";
        //[4] 배열 형식의 필드
        private string[] address = { "서울", "인천", "수원" };
        //[5] object 형식의 필드
        private object all = System.DateTime.Now.ToShortTimeString();


        //[6] public한 메서드
        public void ShowProfile()
        {
            Debug.Log($"이름:{name}, 나이:{AGE}, 별명:{NickName}, 주소:{address[0]}");
        }


    }
}
