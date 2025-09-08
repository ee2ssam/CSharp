using UnityEngine;

public class TypeConversionError : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*//[1] long 형식 변수 선언하고 가장 큰 수를 저장
        long l = long.MaxValue;
        Debug.Log($"l의 값: {l}");

        //[2] int 형식의 변수에 i값을 저장
        int i = (int)l;
        Debug.Log($"i의 값: {i}");*/

        //-21억~21억
        int x = 255;

        //0~255
        byte y = (byte)x;
        Debug.Log(x + "->" + y);

    }
}
