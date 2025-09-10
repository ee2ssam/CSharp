using UnityEngine;

public class ContinueDemo : MonoBehaviour
{
    public int n = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //1부터 n(100)까지의 정수의 합
        //3의 배수를 합에서 제외
        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0)  //3의 배수 판별식
            {
                continue;
            }   

            //sum = sum + i;
            sum += i;   //누적식
        }

        //출력
        Debug.Log(sum);
    }
}

/*
[Q]
1부터 100까지의 정수의 합을 구하는데 3의 배수를 제외하고 합을 구하세요

*/