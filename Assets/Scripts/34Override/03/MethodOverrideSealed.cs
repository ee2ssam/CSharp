using UnityEngine;

namespace MethodOverride
{
    public class MethodOverrideSealed : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //부모 클래스 인스턴스 생성
            ParentDev parent = new ParentDev();
            parent.Work();

            //자식 클래스 인스턴스 생성
            ChildDev child = new ChildDev();
            child.Work();

            //손자 클래스 인스턴스 생성
            GrandChildDev grandChild = new GrandChildDev();
            grandChild.Work();
            grandChild.Play();

        }
    }
}
