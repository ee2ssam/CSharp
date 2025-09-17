using UnityEngine;

namespace Field
{
    //Schedule 클래스 : 사용자 정의 데이터 형식
    public class Schedule
    {
        //[1] 필드(전역변수) - 배열 선언하고 초기화
        string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

        //[2] 메서드(인스턴트)
        public void PrintWeekDays()
        {
            for (int i = 0; i < weekDays.Length; i++)
            {
                Debug.Log(weekDays[i]);
            }
        }

    }
}
