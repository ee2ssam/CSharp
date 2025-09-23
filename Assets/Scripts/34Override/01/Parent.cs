using UnityEngine;

namespace OverrideDemoTest
{
    //부모 클래스
    public class Parent
    {
        //메서드
        public void Say() => Debug.Log("부모 안녕하세요");
        public void Run() => Debug.Log("부모 달린다");
        public virtual void Walk() => Debug.Log("부모 걷다");
    }

    //Parent 클래스를 상속받는 자식 클래스
    //부모 클래스의 메서드를 재정의해서 사용
    public class Child : Parent
    {
        //[1] 재정의 - 그냥 가져다가 재정의 한다
        public void Say() => Debug.Log("자식 안녕하세요");
        //public new void Say() => Debug.Log("자식 안녕하세요");

        //[2] 재정의 - new 키워드를 사용한다
        public new void Run() => Debug.Log("자식 달린다");
        //[3] 재정의 - vitual 정의된 함수를 override 키워드로 재정의 한다
        public override void Walk() => Debug.Log("자식 걷다");
    }
}