using UnityEngine;

namespace Method
{
    public class ExpressionFunction : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Work(); //Work
            Hello(); //Hello
            Debug.Log(DoubleValue(4)); //8
            Debug.Log(Sum(3, 5));   //8
        }

        //[1] 기본 형식
        void Work()
        {
            Debug.Log("Work");
        }

        //축약형
        void Hello() => Debug.Log("Hello");

        //매개변수로 입력 받은 정수 값을 두배로 반환하는 함수
        int DoubleValue(int value) => value * 2;

        //매개변수로 입력 받은 두개의 정수의 합을 반환하는 함수
        int Sum(int a, int b) => a + b;



    }
}