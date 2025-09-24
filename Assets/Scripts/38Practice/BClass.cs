using UnityEngine;

namespace Practice
{
    public class BClass : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //AClass의 인스턴스 멤버 함수 호출하기
            //AClass의 인스턴스 생성
            AClass aClass = new AClass();
            aClass.PrintWeekDays();

            //AClass의 정적(static) 멤버 함수 호출해서 반환받은 값 출력하기
            //AClass이름.정적멤버함수이름
            Debug.Log(AClass.Sum(5, 6));

        }
    }
}
