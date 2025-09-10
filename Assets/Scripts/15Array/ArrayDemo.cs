using UnityEngine;

public class ArrayDemo : MonoBehaviour
{
    public int n = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]배열 선언 - 정수형 데이터를 담는 배열 선언
        int[] numbers;

        //[2]배열의 요소수 생성, 배열의 크기 지정 - 그릇 갯수 지정(n)
        numbers = new int[10]; //0 ~ 9, 0 ~ n-1

        //[3]배열의 초기화
        numbers[0] = 3480;
        numbers[1] = 2160;

        //[4]배열의 사용
        Debug.Log($"{numbers[0]}, {numbers[1]}, {numbers[2]}");

    }
}

/*
배열(array): 하나의 이름으로 같은 데이터 형식을 여러개 보관해 놓는 그릇

배열 선언
데이터 타입[] 변수명(이름)
*/