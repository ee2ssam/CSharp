using UnityEngine;

//[Q] DoWhile문을 이용해서 1부터 100까지의 정수중 홀수들의 합을 구하는 프로그램 구현
public class DoWhileSum : MonoBehaviour
{
    //변수 선언하고 초기화
    public int n = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int sum = 0; //합을 저장하는 변수

        //[1]초기화
        int i = 1;

        do
        {
            //반복 실행문
            if(i % 2 != 0)  //홀수 판별식
            {
                sum = sum + i;
            }

            //[2]증감식
            i++;

        } while (i <= n); //[3]조건식

        Debug.Log(sum);
    }
}
