using UnityEngine;

//MyMath 클래스 만들기
public class MyMath
{
    //[1]인스턴스 메서드 생성 - 두수의 합을 구하는 함수
    public void Sum(int x, int y)
    {
        int sum = x + y;
        Debug.Log($"합계: {sum}");
    }
}


public class ClassMethod : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] MyMath 클래스의 인스턴스 만들기
        //클래스이름 인스턴스이름 = new 클래스이름();
        MyMath myMath = new MyMath();

        //[3] Sum 인스턴스 메서드 사용
        //인스턴스이름.인스턴스메서드이름()
        myMath.Sum(3, 5);

    }
}
