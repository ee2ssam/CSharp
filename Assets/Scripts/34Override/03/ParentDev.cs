using UnityEngine;

namespace MethodOverride
{
    //부모 클래스
    public class ParentDev
    {
        //재정의가 가능한 메서드
        public virtual void Work()
        {
            Debug.Log("프로그래머");
        }
    }

    //자식 클래스
    public class ChildDev : ParentDev
    {
        //virtual -> override
        //sealed 키워드를 이용하여 멤버 봉인
        public override sealed void Work()
        {
            //base 키워드로 부모 멤버에게 접근이 가능
            base.Work();
        }
    }

    //손자 클래스
    public class GrandChildDev : ChildDev
    {
        //멤버가 봉인(sealed)되어 재정의 불가
        /*public override void Work()
        {
            base.Work();
        }*/

        public void Play()
        {
            Debug.Log("프로게이머");
        }

    }
}