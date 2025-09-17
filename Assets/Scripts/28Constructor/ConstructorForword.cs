using UnityEngine;

namespace Constructor
{
    public class ConstructorForword : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Money 클래스의 인스턴스(객체) 생성
            Money basic = new Money();  //기본 생성자 호출
            Money bonus = new Money(2000);  //매개변수가 있는 생성자 호출

            //WithService 클래스의 인스턴스 생성
            WithService file = new WithService();
            file.Run();

            WithService db = new WithService("DB 로그");
            db.Run();
        }
    }
}