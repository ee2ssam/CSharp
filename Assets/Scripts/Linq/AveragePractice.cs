using UnityEngine;

public class AveragePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] data = { 90, 65, 78, 50, 95 };

        //평균 점수 = 총점 / 점수의 갯수
        double average = 0;
        int sum = 0;
        int count = 0;

        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] >= 70 && data[i] <= 95)
            {
                sum = sum + data[i];
                count++;
            }
        }

        if(count > 0)
        {
            average = sum / (double)count;
        }
        //average = 3.1;
        Debug.Log($"평균점수: {average:#.##}");
        //Debug.Log($"평균점수: {average:0.00}");
    }
}

/*
[Q]
입력데이터  {90, 65, 78, 50, 95}
국어 점수중 70점 이상이고 95점 이하인 점수들의 평균을 구하라

[output] - 소수점 2자리
평균점수: average
*/