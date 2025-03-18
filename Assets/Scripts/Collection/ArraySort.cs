using UnityEngine;

// Sort(정렬): 오름차순(1, 2, 3, ....), 내림차순(3, 2, 1)
public class ArraySort : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] arr = { 3, 2, 1, 4, 5 };

        for (int i = 0; i < arr.Length; i++)
        {
            Debug.Log(arr[i]);
        }
        Debug.Log("============");

        //Sort - 오름차순 정렬
        System.Array.Sort(arr);

        foreach (var num in arr)
        {
            Debug.Log(num);
        }
        Debug.Log("============");

        //Reverse - 배열의 역순 정렬
        System.Array.Reverse(arr);

        foreach (var num in arr)
        {
            Debug.Log(num);
        }
        Debug.Log("============");

    }
}
