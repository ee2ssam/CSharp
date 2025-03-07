using UnityEngine;

// Index(인덱스) : 몇 번째의 방, [ ] 안에 들어가는 변수, 값
public class ArrayIndex : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //크기가 3인 정수형 배열 선언하고 초기화
        int[] numbers = { 1, 2, 3 };
        //numbers[0] -> 1, numbers[1] -> 2, numbers[2] -> 3

        //배열의 인덱스를 관리하는 변수, 0으로 초기화, 인덱스의 범위 0 ~ n-1(2)
        int index = 0;

        Debug.Log(numbers[index++]); // => numbers[0] => 1, index: 1
        Debug.Log(numbers[index++]); // => numbers[1] => 2, index: 2
        Debug.Log(numbers[index++]); // => numbers[2] => 3, index: 3

        Debug.Log(numbers[--index]); // => index: 2, numbers[2] => 3
        Debug.Log(numbers[--index]); // => index: 1, numbers[1] => 2
        Debug.Log(numbers[--index]); // => index: 0, numbers[0] => 1

    }
}
