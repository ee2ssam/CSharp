using UnityEngine;

public class ForPractice : MonoBehaviour
{
    public int n = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int sum = 0;

        for (int i = 1; i <= n; i++) //n(100)번 반복
        {
            /*if(i % 3 == 0 || i % 4 == 0)
            {
                sum = sum + i;
            }*/

            if(i % 3 == 0)
            {
                sum = sum + i;
            }
            else if (i % 4 == 0)
            {
                sum = sum + i;
            }
        }

        Debug.Log(sum);
    }
}

/*
[Q]
1부터 n(100)까지의 정수 중에서 3의 배수 또는 4의 배수 들의 합을 구하는 프로그램 구현
*/