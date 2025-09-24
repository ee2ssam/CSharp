using UnityEngine;

namespace Practice
{
    public class Average : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //평균을 구하라
            //평균 = 총합 / (총합을 더한)갯수

            //변수 선언 및 초기화
            int[] scores = { 100, 75, 50, 37, 90, 95 };
            int total = 0;
            int count = 0;
            double avg = 0;

            //총합, 갯수 구하기
            for (int i = 0; i < scores.Length; i++)
            {
                //70점 이상이고 95점 이하인 점수들의 총합
                if(scores[i] >= 70 && scores[i] <= 95)
                {
                    total += scores[i];
                    count++;
                }
            }

            //평균 구하기
            if (count > 0)
            {
                avg = total / (double)count;
            }

            //출력
            Debug.Log($"70점 이상이고 95점 이하인 점수들의 평균: {avg:0.00}");

        }
    }
}


/*
[Q]
데이터 { 100, 75, 50, 37, 90, 95 }
국어 점수 중 70점 이상이고 95점 이하인 점수들의 평균을 구하라

[output]
70점 이상이고 95점 이하인 점수들의 평균: ?
*/