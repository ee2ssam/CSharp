using UnityEngine;
using System.Collections;

public class QueueDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]Queue 클래스의 인스턴스(객체, 개체) 생성
        Queue queue = new Queue();

        //[2]큐에 데이터 입력 : Enqueue
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        //[3]큐에서 데이터 꺼내서 출력하기: Dequeue
        Debug.Log(queue.Dequeue());
        Debug.Log(queue.Dequeue());
        Debug.Log(queue.Dequeue());
    }
}

/*
Queue 클래스 : FIFO(First In First Out, 선입선출) 형태의 데이터를 저장, 관리하는 클래스,
: 먼저 들어간 놈이 먼저 나온다, 은행,병원의 대기표

Enqueue() : 큐 데이터 구조에 데이터 넣기, 저장
Dequeue() : 큐 데이터 구조에서 데이터 꺼내기

*/

