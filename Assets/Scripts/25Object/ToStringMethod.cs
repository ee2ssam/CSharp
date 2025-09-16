using UnityEngine;

public class My
{

}

public class Your
{
    //ToString() 메서드를 다시 정의하여 새로운 문자열 출력
    public override string ToString()
    {
        return "새로운 반환 문자열 지정";
    }
}

public class ToStringMethod : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //My 클래스의 인스턴스(객체) 생성
        My my = new My();
        Debug.Log(my);      //인스턴스를 콘솔창에 출력하면 클래스 이름이 출력

        //Your 클래스의 인스턴스(객체) 생성
        Your your = new Your();
        Debug.Log(your);    //Your

    }
}
