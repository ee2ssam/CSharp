using UnityEngine;

public class IntegerDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int min = int.MinValue;
        int max = int.MaxValue;

        Debug.Log("int 최소값: " + min);
        Debug.Log("int 최대값: " + max);
    }
}

/*
정수형(Integer) 데이터 형식

SignedInteger (+, -) 부호가 있는 정수형 데이터 형식
sbyte :  8 Bit - -128~127
short : 16 Bit - -32768 ~ 32767
int   : 32 Bit - -21억 ~ + 21억
long  : 64 Bit - 

1 Byte : 8비트

UnSignedInteger 부호가 없는 정수형 데이터 형식
byte :  8 Bit - 0~255
ushort : 16 Bit - 0 ~ 65535
uint   : 32 Bit - 0 ~ + 42억
ulong  : 64 Bit - 





*/
