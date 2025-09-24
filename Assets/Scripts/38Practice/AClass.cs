using UnityEngine;

namespace Practice
{
    public class AClass
    {
        //필드(멤버변수, 전역변수) 만들기
        //string 배열, 초기값 { 일, 월, 화, 수, 목, 금, 토 }
        private string[] weekDays = { "일", "월", "화", "수", "목", "금", "토" };

        //인스턴스 멤버 함수 만들기
        //필드에서 선언된 배열 값을 출력하기
        public void PrintWeekDays()
        {
            foreach (string day in weekDays)
            {
                Debug.Log(day);
            }
        }

        //정적(static) 멤버 함수 만들기
        //두개의 정수를 매개변수로 입력받아 두 수를 합한 후 결과 값을 반환하기
        public static int Sum(int x, int y)
        {
            return x + y;
        }

    }
}


/*
[Q]
1) AClass 기본 클래스 만들기 
2) 필드(멤버변수, 전역변수) 만들기
: string 배열, 초기값 { 일, 월, 화, 수, 목, 금, 토 }
3) 인스턴스 멤버 함수 만들기
: 필드에서 선언된 배열 값을 출력하기
4) 정적(static) 멤버 함수 만들기 
: 두개의 정수를 매개변수로 입력받아 두 수를 합한 후 결과 값을 반환하기

1) Monobehaviour 클래스를 상속받는 BClass 만들기
2) AClass의 인스턴스 멤버 함수 호출하기
3) AClass의 정적(static) 멤버 함수 호출해서 반환받은 값 출력하기
: 매개변수 (5, 6)


[output]
일
월
화
수
목
금
토
11


*/