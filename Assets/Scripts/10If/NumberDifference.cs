using UnityEngine;

//두개의 정수를 입력받아 두 정수의 차이를 양의 정수로 구하세요
public class NumberDifference : MonoBehaviour
{
    //정수형 변수 선언하고 0으로 초기화
    public int first = 0;
    public int second = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //두수의 차이를 저장하는 변수
        int diff = 0;

        //두수의 차이를 구하는 식, 두수 비교 후 큰수에서 작은수를 뺀다
        if(first >= second)
        {
            diff = first - second;  //first가 second보다 클때
        }
        else
        {
            diff = second - first;  //second가 first보다 클때
        }   

        //두수의 차이 출력
        Debug.Log($"{first}와 {second}의 차이는 {diff} 이다");
    }
}


/*
[Q]
두개의 정수를 입력받아 두 정수의 차이를 양의 정수로 구하세요
first, second

[output]
{first} 과 {second}의 차이는 {diff}이다
*/