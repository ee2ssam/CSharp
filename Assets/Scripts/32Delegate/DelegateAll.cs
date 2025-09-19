using UnityEngine;
using System;

namespace Delegate
{
    public class DelegateAll : MonoBehaviour
    {
        //[1] 대리자 선언(생성) - 반환값이 없고, 매개변수 없다
        delegate void GoHome();
        //[2] 대리자 변수 선언
        GoHome go;

        //인사하는 대리자 선언(생성) - 반환값이 없고, 매개변수 없다
        delegate void Say();

        //Action 형식을 통해 대리자 객체를 생성: Action, Func
        Action driver;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //직진 -> 우회전 -> 직진 -> 좌회전

            //직접운전
            CarDriver.GoForward();
            CarDriver.GoRight();
            CarDriver.GoForward();
            CarDriver.GoLeft();

            Debug.Log("=======================");

            //[3] 대리자 변수에 메서드 등록
            go = new GoHome(CarDriver.GoForward);
            go += new GoHome(CarDriver.GoRight);
            go += new GoHome(CarDriver.GoForward);
            go += new GoHome(CarDriver.GoLeft);
            go += new GoHome(CarDriver.GoForward);  //메서드 등록
            go -= new GoHome(CarDriver.GoForward);  //메서드 취소

            //[4] 대리자 실행(호출)
            go.Invoke();

            Debug.Log("=======================");

            //대리자 변수 선언 및 메서드 등록
            Say say = new Say(Hello);
            say += new Say(Hi);
            say.Invoke();

            Debug.Log("=======================");

            //Insa 클래스의 인스턴스 생성
            Insa insa = new Insa();

            //대리자 변수 선언 및 메서드 등록
            Say say2 = insa.Bye;
            say2 += Hi;
            say2.Invoke();

            Debug.Log("=======================");

            //Action
            driver = CarDriver.GoForward;
            driver += CarDriver.GoRight;
            driver += () => Debug.Log("후진");
            driver += delegate () { Debug.Log("주차"); }; //무명 함수, 익명 함수
            driver.Invoke();
        }

        void Hi()
        {
            Debug.Log("Hi");
        }

        void Hello() => Debug.Log("Hello");
        
    }
}