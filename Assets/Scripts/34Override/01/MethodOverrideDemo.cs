using UnityEngine;
using OverrideDemoTest;

namespace MethodOverride
{
    //MethodOverride(메서드 재정의)
    //부모 클래스의 메서드를 재정의(다시 정의, 선언)해서 사용하기
    public class MethodOverrideDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //자식 클래스 인스턴스 생성
            Child child = new Child();

            child.Say();    //[1] 그냥 재정의
            child.Run();    //[2] new 
            child.Walk();   //[3] vitual -> override

        }
    }
}