using UnityEngine;
using System.Collections;

public class QueueDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]Queue클래스의 인스턴스(객체, 개체) 생성
        Queue queue = new Queue();

        //[2]큐에 데이터 넣기 Enqueue
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        //[3]큐에서 데이터 꺼내기 Dequeue - 출구쪽의 맨 앞에 있는 데이터를 꺼낸다
        Debug.Log(queue.Dequeue());
        Debug.Log(queue.Dequeue());
        Debug.Log(queue.Dequeue());
    }
}

/*
Queue 클래스 : FIFO(First in First out) 형태로 데이터를 저장 관리하는 클래스
FIFO(First in First out) : 선입선출, 가장 먼저 넣은 데이터를 가장 먼저 꺼낸다
- 터널형 창고 데이터 구조, 대기표

Enqueue() : 큐에 데이터 넣기
Dequeue() : 큐에서 데이터 꺼내기


*/

