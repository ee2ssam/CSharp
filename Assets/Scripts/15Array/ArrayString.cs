using UnityEngine;

// string : 문자(배)열
public class ArrayString : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //문자열 변수 선언 및 초기화
        string arr = "C#8";

        /*Debug.Log(arr);
        Debug.Log(arr[0]);
        Debug.Log(arr[1]);
        Debug.Log(arr[2]);*/
        //char
        foreach(var c in arr)
        {
            Debug.Log(c);
        }
    }
}
