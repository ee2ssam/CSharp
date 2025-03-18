using UnityEngine;

public class ClassTwo : MonoBehaviour
{
    //정적(static) 멤버 메서드 
    public static void Hi()
    {
        Debug.Log("반갑습니다");
    }

    //인스턴스(instance) 멤버 메서드 - static 없는 메서드
    public void Hello()
    {
        Debug.Log("또 만나요");
    }
}
