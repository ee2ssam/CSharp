using Unity.Burst.Intrinsics;
using UnityEngine;

public class ArrayTwoNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1-1] 2차원 배열 선언, 요소수(크기) 생성, 초기화
        //int[,] intArray = new int[2, 3] { { 1,2,3 }, { 4,5,6 } };
        //[1-2] 2차원 배열 선언, 요소수 크기 생략, 초기화
        //int[,] intArray = new int[,] { { 1,2,3 }, { 4,5,6 } };
        //[1-3] 2차원 배열 선언, 초기화
        int[,] intArray = { { 1, 2, 3 }, { 4, 5, 6 } };

        Debug.Log($"배열의 길이: {intArray.Length}");

        //출력 : 행의 길이 intArray.GetLength(0)
        for ( int i = 0; i < intArray.GetLength(0); i++ ) //i:0,1
        {
            //열의 길이 : intArray.GetLength(1)
            for (int j = 0; j < intArray.GetLength(1); j++) //j:0,1,2
            {
                Debug.Log($"intArray[{i},{j}] : {intArray[i,j]}");
            }
        }
    }
}
