using UnityEngine;

// doWhile문을 이용해서 1부터 n(100)까지의 정수중에서 홀수의 합을 구하는 프로그램 구현 
public class DoWhileSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 100;
        int sum = 0;

        //초기식
        int i = 1;

        do
        {
            //반복실행문
            if(i % 2 != 0) //홀수 판별식
            {
                sum = sum + i;
            }

            //증감식
            i++;
        } while (i <= n); //조건식

        Debug.Log($"1부터 {n}까지의 홀수의 합: {sum}");

    }
}
