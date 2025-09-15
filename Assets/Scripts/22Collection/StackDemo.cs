using UnityEngine;
using System.Collections;

public class StackDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] Sta차 클래스의 객체(개체, 인스턴스) 생성
        Stack stack = new Stack();

        //[2] 데이터 입력
        stack.Push("첫번째");
        stack.Push("두번째");
        stack.Push("세번째");

        //[3] 데이터 꺼내서 출력
        Debug.Log(stack.Pop());
        Debug.Log(stack.Pop());
        Debug.Log(stack.Pop());

        //비어있는 스텍에서 Pop()
        try
        {
            Debug.Log(stack.Pop());
        }
        catch (System.Exception ex)
        {
            Debug.Log($"에러내용: {ex.Message}");
        }
    }
}

/*
Stack 클래스 : LIFO(Last In First Out, 후입선출) 형태로 데이터를 저장 관리하는 클래스
: 나중에 들어간 놈이 먼저 나온다

Count : 스택 구조에 들어있는 데이터의 갯수
Push() : 스택 구조에 데이터 입력
Pop() : 스택 구조에서 데이터 출력
Peek() : 우물의 맨위 상단에 있는 데이터 읽어오기, 제일 마지막에 들어온 데이터 읽기

Overflow : 스택이 가득 찼을때 발생하는 에러
UnderFlow : 스택이 비어있을때 발생하는 에러
*/
