using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GenericDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]제네릭 사용전
        Stack st1 = new Stack();
        st1.Push(1234); //박싱, 
        int number1 = (int)st1.Pop();   //타입변환 필요, 언박싱
        Debug.Log(number1);

        //[2]제네릭 사용시
        Stack<int> st2 = new Stack<int>();
        st2.Push(5678);
        int number2 = st2.Pop();
        Debug.Log(number2);

        //[3]제네릭 장점: 형식의 안정성, 성능 향상
        //형식의 안정성
        Stack o = new Stack();
        o.Push(1234);
        o.Push("Hello");
        Debug.Log(o.Pop());
        Debug.Log(o.Pop());

        Stack<int> i = new Stack<int>();
        i.Push(2345);
        //i.Push("TEN"); //int만 처리 가능
        Debug.Log(i.Pop());

        //성능, 최적화
        Stack stack = new Stack();
        stack.Push(1234); // 1234(값형) -> obejct(참조형) 저장 : 박싱
        int iStack = (int)stack.Pop(); //obejct(참조형) -> 1234(값형) : 언박싱
        Debug.Log(iStack);
    }
}
