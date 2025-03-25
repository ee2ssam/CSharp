using UnityEngine;

namespace Override
{
    //Method Override(메서드 재정의, 메서드 오버라이드)
    //부모클래스의 메서드를 재정의(다시 정의)해서 사용하기
    public class MethodOverrideDescription : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Child 클래스의 인스턴스 생성
            /*Child child = new Child();
            child.Say();
            child.Run();
            child.Walk();*/

            //Overloading
            int iNumber = 100;
            double dNumber = 3.14;

            PrintNumber(iNumber);
            PrintNumber(dNumber);
            PrintNumber(3, 5);

        }

        //Method Overload, Overloading
        void PrintNumber(int number) => Debug.Log($"{number}");
        void PrintNumber(double number) => Debug.Log($"{number}");
        void PrintNumber(int a, int b) => Debug.Log($"{a + b}");
    }
}


/*
Method Override(메서드 재정의, 메서드 오버라이드)
:상속의 개념에서 나온다
:부모클래스의 메서드를 재정의(다시 정의)해서 사용하기


Method Overload, Overloading(다중정의, 여러번 정의, 함수 중복)
:한 클래스 코드블록 안에서 구현
:함수 이름은 같고 매개변수가 틀리게 여러번 정의해서 사용하기
*/





