using UnityEngine;

namespace Delegate
{
    //반환값도 있고, 매개변수도 있는 메서드의 델리게이트 만들기
    public class DelegateNote : MonoBehaviour
    {
        //[1]델리게이트 정의(생성) - double형 반환, 매개변수 int
        //delegate double 대리자이름 (int)
        delegate double GetCircleArea(int r);

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[2]델리게이트 변수 선언하고 메서드 등록
            GetCircleArea area = GetArea;

            //[3]델리게이트 호출
            Debug.Log(area(10));
            Debug.Log(area.Invoke(10));
        }

        //메서드
        //매개변수로 반지름의 길이를 입력받아 원의 면적을 계산하여 반환하는 함수
        private double GetArea(int r)
        {
            return 3.14 * r * r;
        }
    }
}
