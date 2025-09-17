using UnityEngine;

namespace Constructor
{
    public class DestructerTest
    {
        //생성자
        public DestructerTest()
        {
            Debug.Log("[1] 생성");
        }

        //사용 - 메서드
        public void Run()
        {
            Debug.Log("[2] 실행");
        }

        //소멸자: GC가 호출
        ~DestructerTest()
        {
            Debug.Log("[3] 소멸");
        }
    }
}