using UnityEngine;

namespace Constructor
{
    public class ContructorOverload : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //ConstructorLog 클래스의 인스턴스 생성
            //기본 생성자를 호출하여 인스턴트 생성
            ConstructorLog log1 = new ConstructorLog();
            //매개변수 string이 있는 생성자를 호출하여 인스턴트 생성
            ConstructorLog log2 = new ConstructorLog("홍길동");
            //매개변수 string이 있는 생성자를 호출하여 다른 인스턴트 생성
            ConstructorLog log3 = new ConstructorLog("백두산"); 
        }
    }
}