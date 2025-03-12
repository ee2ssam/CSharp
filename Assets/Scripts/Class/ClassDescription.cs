using UnityEngine;

public class ClassDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Run();  //같은 클래스의 메서드 호출
        ClassDescription.Run(); //클래스 레벨의 메서드 호출: 클래스이름.메서드() 호출
    }

    //ClassDescription 라는 클래스의 Run (정적)메서드(함수)
    static void Run()
    {
        Debug.Log("ClassDescription 라는 클래스의 Run 메서드");
    }
}

/*
class(클래스) - C# 기본이 되는 구문
: 하나의 이름으로 서로 다른 (형식의) 데이터들과 함수들을 묶어서 관리하는 그릇(구문)
: ....
: 사용자 정의 데이터 형식

public class (클래스 이름)
{

}

*/

