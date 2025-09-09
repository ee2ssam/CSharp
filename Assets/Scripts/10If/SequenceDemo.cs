using UnityEngine;

public class SequenceDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int kor = 100;
        int eng = 90;

        int total = 0;  //총점
        double avg = 0.0;   //평균 점수

        total = kor + eng;  //총점 구하기
        avg = total / 2.0;  //평균 구하기

        Debug.Log($"총점: {total}");
        Debug.Log($"평균: {avg:F1}"); //소수점 첫째점까지만 출력
    }
}

/*
- 제어문 : 프로그램의 흐름(순서)를 정하는 명령문
[1] 순차문 : 기본적으로 모든 명령문은 순서대로 (위에서 아래로) 실행 된다
[2] 조건문 : if, switch
[3] 반복문 : for, while
[4] 기타: ?



*/