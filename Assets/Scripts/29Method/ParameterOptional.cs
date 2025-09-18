using UnityEngine;

namespace Method
{
    //선택적 매개변수
    public class ParameterOptional : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Debug.Log(Add(3, 5));   //3 + 5 = 8
            Debug.Log(Add(3));      //3 + 1 = 4
        }

        //선택적 매개변수
        //매개변수로 받은 두개의 정수의 합을 반환하는 함수
        //함수 호출시 매개변수 b값은 생략가능하다, 생략하면 b값은 1로 연산된다
        int Add(int a, int b = 1)
        {
            return a + b;
        }
    }
}