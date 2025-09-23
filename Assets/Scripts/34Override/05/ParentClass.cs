using UnityEngine;

namespace MethodOverride
{
    //부모 클래스
    public class ParentClass
    {
        public virtual void Hi()
        {
            Debug.Log("부모 안녕하세요");
        }
    }

    //자식 클래스
    public class ChildClass : ParentClass
    {
        public override void Hi()
        {
            Debug.Log("자식 안녕하세요");
        }
    }
}
