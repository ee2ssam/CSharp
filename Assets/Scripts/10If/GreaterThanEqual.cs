using UnityEngine;

//2개의 수를 입력 받아 그중 큰 수를 출력한다
public class GreaterThanEqual : MonoBehaviour
{
    //두개의 정수 first, second 변수 선언하고 0으로 초기화
    public int first = 0;
    public int second = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //입력 받은 first와 second 값을 비교하여 큰 값 출력
        //만약 first가 second 이상이면 first 출력
        if(first >= second)
        {
            Debug.Log($"큰 값은: {first}");
        }
        else //first가 second 이상이 아니면 second 출력
        {
            Debug.Log($"큰 값은: {second}");
        }
    }
}
