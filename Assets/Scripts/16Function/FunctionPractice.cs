using UnityEngine;

public class FunctionPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //입력값: 6, 3
        int result = Add(6, 3);
        Debug.Log($"6 + 3 = {result}");

        result = Substract(6, 3);
        Debug.Log($"6 - 3 = {result}");

        result = Multiply(6, 3);
        Debug.Log($"6 * 3 = {result}");

        result = Divide(6, 3);
        Debug.Log($"6 / 3 = {result}");

        result = Remainder(6, 3);
        Debug.Log($"6 % 3 = {result}");

        Hi("안녕!!!");
    }

    //+
    int Add(int x, int y)
    {
        //int sum = x + y;
        //return sum;

        return x + y;
    }

    //-
    int Substract(int x, int y) { return x - y; }

    //*, /, %
    int Multiply(int x, int y) => x * y;
    int Divide(int x, int y) => x / y;
    int Remainder(int x, int y) => x % y;

    void Hi(string msg) => Debug.Log(msg);
}


/*
[Q]
사칙연산을 구하는 함수 만들기
- 매개변수로 두개의 정수를 입력받아 +, -, *, /, % 연산한다
- 연산 결과 값을 반환하는 함수 구현

입력값: 6, 3
[Output]
6 + 3 = 9
6 - 3 = 3
...

*/