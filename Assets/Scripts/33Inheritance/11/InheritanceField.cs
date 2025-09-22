using UnityEngine;
using InheritanceFieldTest;

namespace Inheritance
{
    public class InheritanceField : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //SubClass의 인스턴스 생성
            SubClass sub = new SubClass();
            sub.SetWord("필드 숨기기 및 자식 클래스에게만 멤버 상속");
            Debug.Log(sub.GetWord());
        }
    }
}