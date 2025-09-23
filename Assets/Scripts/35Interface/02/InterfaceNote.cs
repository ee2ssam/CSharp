using UnityEngine;

namespace InterfaceDemoTest
{
    public class InterfaceNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //인터페이스의 형식 객체에 인터페이스를 상속받은 클래스의 인스턴스 담기
            IRepository repository = new Repository();
            repository.Get();
        }
    }
}