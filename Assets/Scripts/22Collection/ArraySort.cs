using UnityEngine;

public class ArraySort : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //배열의 정렬(sort)
        int[] arr = { 3, 2, 1, 4, 5 };

        //sort - 오름차순: 0 1 2
        System.Array.Sort(arr);

        foreach (var i in arr)
        {
            Debug.Log(i);
        }

        Debug.Log("=====================");

        //배열의 역순: 지금 정렬되어 있는 순서를 거꾸로 정렬
        System.Array.Reverse(arr);

        foreach (var i in arr)
        {
            Debug.Log(i);
        }

        //ConvertAll: 문자열 배열을 정수형 배열로 형변환
        string[] strArray = { "10", "20", "30" };
        int[] intArray = System.Array.ConvertAll(strArray, int.Parse);

        foreach(int i in intArray)
        {
            Debug.Log(i);
        }
    }
}
