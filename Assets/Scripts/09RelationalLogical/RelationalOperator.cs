using UnityEngine;

// RelationalOperator(관계연산자, 비교연산자)
// < (작음), <= (작거나 같음), > (큼), >= (크거나 같음), == (같음), != (다름)
// 결과 : true(참), false(거짓)
public class RelationalOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 3;
        int y = 5;

        Debug.Log(x < y);   //x(3)는 y(5)보다 작으냐?
        Debug.Log(x <= y);  //x(3)는 y(5)보다 작거나 같으냐?
        Debug.Log(x > y);   //x(3)는 y(5)보다 크냐?
        Debug.Log(x >= y);  //x(3)는 y(5)보다 크거나 같으냐?
        Debug.Log(x == y);  //x(3)와 y(5)는 같으냐?
        Debug.Log(x != y);  //x(3)와 y(5)는 다르냐?

        Debug.Log("AAA" == "aaa");  //False
    }
}
