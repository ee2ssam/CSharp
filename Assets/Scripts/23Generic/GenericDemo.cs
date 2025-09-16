using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GenericDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 제네릭 사용전        
        Stack st1 = new Stack();    //스택 클래스 인스턴스 생성
        st1.Push(1234);             //숫자 데이터 입력
        int number1 = (int)st1.Pop();    //숫자 데이터 꺼내오기, 타입 컨버팅이 필요
        Debug.Log(number1);

        //[2] 제네릭 사용후
        Stack<int> st2 = new Stack<int>();  //int 전용 스택 (제네릭)클래스 인스턴스 생성
        st2.Push(5678);                     //숫자 데이터 입력
        int number2 = st2.Pop();            //숫자 데이터 꺼내오기, 타입 컨버팅 필요없다
        Debug.Log(number2);

        //[3] 제네릭 클래스의 장점: 형식의 안정성, 성능 향상
        //형식의 안정성
        Stack o = new Stack();
        o.Push(2345);
        o.Push("Hello");
        Debug.Log(o.Pop());
        Debug.Log(o.Pop());

        Stack<int> i = new Stack<int>();
        i.Push(9871);           //넣은 데이터도 무조건 정수
        //i.Push("안녕하세요"); //에러발생
        Debug.Log(i.Pop());     //꺼내는 데이터는 무조건 정수

        //성능 향상, 최적화
        Stack stack = new Stack();
        stack.Push(3456);       // 1234(int형식) to object 형식으로 저장 : 박싱(Boxing) 
        int numbers3 = (int)stack.Pop(); // object 형식 to int형으로 가져온다 : 언박싱(UnBoxing)
        Debug.Log(numbers3);

    }
}
