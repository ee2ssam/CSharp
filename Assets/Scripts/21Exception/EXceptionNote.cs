using UnityEngine;

public class EXceptionNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //런타임중 에러 발생
        try
        {
            int now = System.DateTime.Now.Second;
            Debug.Log($"현재 초: {now}");

            int result = 2 / (now % 2);
            Debug.Log("홀수초에서는 정상 처리");
        }
        catch
        {
            Debug.Log("짝수초에서는 런타임 에러 발상");
        }

    }
}
