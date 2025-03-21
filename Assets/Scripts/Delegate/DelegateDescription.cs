using UnityEngine;

namespace Delegate
{
    public class DelegateDescription : MonoBehaviour
    {
        //[1] 델리게이트 선언 - 대신할 메서드 Hi()
        //반환값도 없고 매개변수도 없는 메서드 대신 실행할 델리게이트 생성
        //deleagate void (대리자 이름) ()
        delegate void SayDelegate();


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //직접 호출
            Hi();

            //[2]대리자의 변수 선언 및 대신할 메서드 등록 1
            SayDelegate say = Hi;
            //대리자 호출 1
            say();

            //[3]대리자의 변수 선언 및 대신할 메서드 등록 2
            SayDelegate hello = new SayDelegate(Hi);
            //대리자 호출 1
            hello();

            //[4]대리자의 변수 선언 및 대신할 메서드 등록 2, 호출2
            SayDelegate insa = new SayDelegate(Hi);
            //대리자 호출 2
            insa.Invoke();

        }

        void Hi()
        {
            Debug.Log("안녕하세요");
        }
    }
}

/*
Delegate(대리자, 대신 실행자)
: 등록(지정)한 메서드를 대신 실행시켜주는 놈
: 매개변수 목록 및 반환 형식이 있는 메서드를 참조로 나타내는 형식

<Delegate 형식>
: 매개변수도 없고, 반환형도 없는 메서드를 대신 실행해 주는 대리자
deleagate void (대리자 이름) ()
*/