using UnityEngine;
using System.Collections;

public class StackClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Stack 클래스의 인스턴스(개체) 생성
        Stack st = new Stack();

        //스택에 데이터 넣기 Push()
        st.Push("First");
        st.Push("Second");

        //스택에 데이터 꺼내기 Pop()
        Debug.Log(st.Pop());
        Debug.Log(st.Pop());

    }
}
