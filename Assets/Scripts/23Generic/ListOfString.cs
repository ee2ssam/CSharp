using UnityEngine;
using System.Collections.Generic;

// 제네릭 리스트 클래스 : List<T> => List<int>, List<string>, List<object>
public class ListOfString : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] <string> 전용의 제네릭 리스트 인스턴스(객체) 생성
        List<string> colors = new List<string>();

        //[2] 리스트에 데이터 입력
        colors.Add("Red");
        colors.Add("Green");
        colors.Add("Blue");

        //[3] 데이터 사용
        for (int i = 0; i < colors.Count; i++)
        {
            Debug.Log(colors[i]);
        }

        foreach (var color in colors)
        {
            Debug.Log(color);
        }
    }
}
