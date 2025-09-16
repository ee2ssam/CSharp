using UnityEngine;

public class ClassTwo
{
    //정적(static) 메서드
    public static void Hi()
    {
        Debug.Log("반갑습니다");
    }

    //인스턴스(Instance) 메서드, static이 없는 메서드
    public void Hello()
    {
        Debug.Log("또 만나요");
    }
}
