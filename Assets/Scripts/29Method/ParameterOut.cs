using UnityEngine;

namespace Method
{
    //[3] 반환형 전달 방법     (out int num) 
    public class ParameterOut : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //정수형 변수 선언, 반드시 초기화 할 필요는 없다
            int number;

            PrintNumber(out number);

            Debug.Log($"[2]: {number}");    //[2] 20

        }

        //정수형 변수 number을 out 매개변수로 입력 받아 출력하는 메서드
        //ref(참조 전달 방법)과 동일
        //함수 내부에서 반드시 초기화(값 설정) 해야 한다
        void PrintNumber(out int number)
        {
            number = 20;
            Debug.Log($"[1]: {number}");    //[1] 20
        }
    }
}