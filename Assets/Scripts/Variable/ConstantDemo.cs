using UnityEngine;

//상수(Constant) : 변하지 않는 변수, 읽기 전용 변수
public class ConstantDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 정수 형식의 상수 선언, 상수는 선언과 동시에 초기화
        const int MAX = 100;

        //[2] 상수 사용하기
        Debug.Log("최대값: " + MAX);

    }
}
