using UnityEngine;

namespace InterfaceDemoTest
{
    //IRepository 상속받는 클래스
    public class Repository : IRepository
    {
        public void Get()
        {
            Debug.Log("Get() 메서드를 구현해야 합니다");
        }
    }
}