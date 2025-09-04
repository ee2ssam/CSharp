using UnityEngine;

public class VariableComma : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //콤마(,)로 여러개의 변수를 한줄에 선언 가능
        //int number1;
        //int number2;
        //int number3;
        int number1, number2, number3;

        //값 대입
        number1 = 1;
        number2 = 2;
        number3 = 3;

        //값 출력
        Debug.Log(number1 + ", " + number2 + ", " + number3);

        //변수 선언
        int a, b, c;

        //값 대입, 여러개의 변수에 같은 값으로 초기화
        //a = 10;
        //b = 10;
        //c = 10;
        a = b = c = 10;

        //변수 출력
        Debug.Log(a + ", " + b + ", " + c);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
