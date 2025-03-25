using UnityEngine;

namespace Override
{
    //부모 클래스
    public class Base
    {
        public virtual void Work() => Debug.Log("부모가 일한다");
    }

    //자식 클래스
    public class Sub : Base
    {
        //sealed 키워드를 사용하여 멤버를 봉인(재정의 금지)
        public override sealed void Work()
        {
            Debug.Log("자식이 일한다");
        }
    }

    //손자 클래스
    public class GrandSub : Sub
    {
        /*public override void Work()
        {
            Debug.Log("손자가 일한다");
        }*/
        
        public void Play() => Debug.Log("손자가 논다");

    }
}
