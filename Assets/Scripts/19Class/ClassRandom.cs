using UnityEngine;
using System;

//Random 클래스 : 랜덤값과 관련된 변수, 메서드들이 있는 클래스
public class ClassRandom : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] Random 클래스의 객체 생성
        System.Random rand = new System.Random();

        Debug.Log(rand.Next()); //임의의 정수 값 생성
        Debug.Log(rand.Next(5));        // 0~4
        Debug.Log(rand.Next(1, 10));    //1~9

    }
}
