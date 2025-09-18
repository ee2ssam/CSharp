using UnityEngine;

namespace Method
{
    public class ParameterIn : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //정수형 변수 num 선언하고 초기화
            int num = 10;
            Debug.Log($"[1]: {num}");   //10

            PrintNumber(num);

            Debug.Log($"[3]: {num}");   //10

        }

        private void PrintNumber(int num)
        {
            num = 20;
            Debug.Log($"[2]: {num}");   //20
        }
    }
}


/*
매개변수(Parameter) 
: 전달되는 방법에 따라 구분
[1] 값 전달 방법         (int num)
[2] 참조 전달 방법       (ref int num)
[3] 반환형 전달 방법     (out int num) 
[4] 가변형 전달 방법     (params int[] numbers)
*/