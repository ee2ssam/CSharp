using UnityEngine;
using System.Collections.Generic;

namespace Genenric
{
    //고객을 관리하는 클래스
    public class User
    {
        public string Name { get; set; }    //고객 이름
        public int Number { get; set; }     //고객 번호
    }

    // List<T> : T (int, string,... 사용자정의 데이터 타입)
    public class GenericNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

            //고객 전용 리스트 선언하고 초기화
            List<User> users = new List<User>
            {
                new User { Name = "홍길동", Number = 1 },
                new User { Name = "장길산", Number = 2 },
                new User { Name = "백두산", Number = 3 },
            };

            //리스트에 추가 (유저 추가)
            //추가할 User 인스턴스 생성
            User user = new User() { Name = "김단비", Number = 4 };
            users.Add(user);

            //리스트 사용 - 고객 리스트 출력
            foreach (var us in users)
            {
                Debug.Log($"{us.Name} - {us.Number}");
            }
        }
    }
}