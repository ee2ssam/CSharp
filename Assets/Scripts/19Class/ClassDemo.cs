using UnityEngine;

//클래스(class): 하나의 이름으로 서로 다른 형식의 데이터들과 함수들을 묶어서 관리
//c# 에서 가장 기본이  되는 구문
//사용자 정의 데이터 형식 
public class ClassDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //메서드 호출, 같은 클래스의 메서드 호출
        //Run();

        //ClassDemo 클래스의 메서드(함수) 호출
        //ClassDemo.Run(); //ClassDemo.메서드이름() 호출

        //Squre 클래스의 GetName() 정적 메서드 호출
        //정적 메서드 호출 방법 : 클래스이름.메서드이름()
        string name = Squre.GetName();
        Debug.Log(name);

    }

    //ClassDemo 클래스의 메서드(함수)
    static void Run()
    {
        Debug.Log("ClassDemo 클래스의 Run 메서드를 호출하였습니다");
    }
}
