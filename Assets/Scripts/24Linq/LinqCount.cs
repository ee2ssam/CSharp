using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class LinqCount : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //정수형 배열의 요소수 카운트
        int[] numbers = { 1, 2, 3, 4, 5 };
        //Debug.Log($"배열의 길이: {numbers.Length}");

        //배열의 요소수 카운트
        int count = numbers.Count();
        Debug.Log($"배열의 요소수 카운드: {count}");

        //배열의 요소들의 평균 구하기
        double avg = numbers.Average();
        Debug.Log($"배열의 요소들의 평균값은 : {avg:#.##}");

        //배열 요소수 중에서 Max,Min 값 구하기
        int max = numbers.Max();
        int min = numbers.Min();
        Debug.Log($"numbers의 최대값:{max}, 최소값:{min}");

        //정수형 배열 numbers의 요소중 3보다 크고 짝수인 수 구하기 + 결과를 리스트에 넣기
        //1. 3보다 크고 짝수인 수 구하기
        //2. 리스트에 넣기

        List<int> listNumbers = numbers.Where(n => n>3 && n%2 == 0).ToList();

        foreach(int n in listNumbers)
        {
            Debug.Log($"{n}");
        }


    }
}
