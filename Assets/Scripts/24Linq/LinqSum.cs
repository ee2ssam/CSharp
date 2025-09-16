using UnityEngine;
using System.Linq;

public class LinqSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //컬렉션 요소들의 합 구하기
        int[] numbers = { 1, 2, 3, 4 };

        //numbers 합 구하기
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        Debug.Log(sum);

        //확장형 메서드 이용
        int sum2 = numbers.Sum();
        Debug.Log(sum2);
        
    }
}
