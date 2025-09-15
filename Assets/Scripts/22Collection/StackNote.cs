using UnityEngine;
using System.Collections;

public class StackNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]Stack 인스턴스(객체) 만들기
        Stack stack = new Stack();

        //[2]데이터 저장
        stack.Push("대한민국");
        stack.Push("경기도");
        stack.Push("수원");

        //[3] Peek() 맨 위에 있는 데이터 읽기
        Debug.Log($"{stack.Peek()}, {stack.Count}");

        //[4] Pop() 스택에서 데이터를 꺼내기, 스택에서 데이터 제거
        stack.Pop();

        //[5] Peek() 맨 위에 있는 데이터 읽기
        Debug.Log($"{stack.Peek()}, {stack.Count}");

        //[6] stack.Count == 0 이면 꺼낼것이 없다
        if(stack.Count > 0)
        {
            stack.Pop();
            Debug.Log($"{stack.Peek()}, {stack.Count}");
        }

        //[7] 스택 비우기 clear()
        stack.Clear();
        Debug.Log($"{stack.Count}");


    }
}
