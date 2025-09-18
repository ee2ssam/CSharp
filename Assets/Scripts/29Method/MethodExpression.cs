using UnityEngine;

namespace Method
{
    //메서드 축약형, 화살표 함수
    public class MethodExpression : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Work();
            Hello();

            Debug.Log(DoubleValue(4));  //8
            Debug.Log(Sum(3, 5));       //8
        }

        //함수 기본형식
        void Work()
        {
            Debug.Log("Work!!!");
        }

        //축약형
        //Hello 출력하는 메서드
        void Hello() => Debug.Log("Hello!!!");

        //매개변수로 입력 받은 정수값을 두배로 반환하는 메서드
        int DoubleValue(int value) => value * 2;

        //매개변수로 입력 받은 두개의 정수의 값의 합을 반환하는 메서드
        int Sum(int a, int b) => a + b;

    }
}