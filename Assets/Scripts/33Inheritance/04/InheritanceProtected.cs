using UnityEngine;
using InheritanceProtectedTest;


namespace Inheritance
{
    public class InheritanceProtected : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[1]부모클래스 인스턴스 생성
            ParentClass parent = new ParentClass();
            //parent.PrintMessage();    //protected (보호수준 때문) 접근 불가
            Debug.Log(parent.ToString());

            //[2]자식클래스 인스턴스 생성
            ChildClass child = new ChildClass();
            //child.PrintMessage();     //protected (보호수준 때문) 접근 불가
            child.PrintMessage2();


        }
    }
}

/*
- public : 접근의 제한이 없다
- private : 해당(현재) 클래스안에서만 접근이 가능하다 
- protected : 해당(현재) 클래스안에서만 접근이 가능하다, 상속받은 자식 클래스에서 접근 가능
*/