using UnityEngine;

namespace Practice
{
    public class Max : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //변수 선언 및 초기화
            int[] numbers = { -2, -5, -4, -7, -1 };

            //최대값을 구하는 변수
            //int 데이터 타입중 가장 작은값으로 초기화
            int maxValue = int.MinValue;

            //최대값 구하기
            for (int i = 0; i < numbers.Length; i++)
            {
                //최대값과 배열의 값을 순서대로 크기 비교
                if (numbers[i] > maxValue)
                {
                    maxValue = numbers[i];  //두수의 크기를 비교하여 크면 maxValue에 저장
                }
            }

            Debug.Log($"최대값은 {maxValue}");

        }
    }
}

/*
데이터 { -2, -5, -4, -7, -1 }
입력된 데이터중 최대값을 구하세요

[output]
최대값은 -1


// -2, -5, -4, -7, -1

maxValue  -2 => maxValue = -2
*/