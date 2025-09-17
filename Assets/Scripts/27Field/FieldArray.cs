using UnityEngine;

namespace Field
{
    public class FieldArray : MonoBehaviour
    {
        //필드
        //Schedule sc;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Schdule 클래스의 인스턴스(개체) 생성
            Schedule schedule = new Schedule();
            schedule.PrintWeekDays();
        }
    }
}