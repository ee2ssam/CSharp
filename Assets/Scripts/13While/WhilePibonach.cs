using UnityEngine;

public class WhilePibonach : MonoBehaviour
{
    //반복 횟수
    public int n = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int first = 0;
        int second = 1;

        //초기식
        int i = 0;

        while(i < n) //조건식
        {
            //반복 실행문
            Debug.Log(second);
            int temp = first + second;
            first = second;
            second = temp;

            //증감식
            i++;
        }

    }
}
