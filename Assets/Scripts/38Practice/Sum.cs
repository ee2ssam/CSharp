using UnityEngine;

namespace Practice
{
    public class Sum : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //변수 선언 및 초기화
            int[] scores = { 100, 75, 50, 37, 90, 95 };
            int total = 0;

            //총합 구하기
            for (int i = 0; i < scores.Length; i++)
            {
                //70점 이상인 점수들의 총합을 구하라
                if(scores[i] >= 70)
                {
                    total += scores[i];
                }
            }

            //출력
            Debug.Log($"70점 이상인 값들의 총합: {total}");
        }
    }
}


/*
[Q]
데이터 { 100, 75, 50, 37, 90, 95 }
국어 점수 중 70점 이상인 점수들의 총합을 구하라

[output]
70점 이상인 값들의 총합: 360
*/
