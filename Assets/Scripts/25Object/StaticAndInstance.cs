using UnityEngine;

//정적(static, shared) 멤버와 인스턴스(Instance) 멤버
// SharedAndInstance 클래스 선언
public class SharedAndInstance
{
    //정적(static, shared) 멤버 함수
    public static void StaticMember() => Debug.Log("[1] Static Member");

    //인스턴스(Instance) 멤버 함수
    public void InstanceMember() => Debug.Log("[2] Instance Member");
}


public class StaticAndInstance : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 정적 멤버 사용(메서드 호출)
        //클래스이름.정적멤버메서드이름() 으로 호출
        SharedAndInstance.StaticMember();

        //[2]인스턴스 멤버 사용
        //인스턴스 멤버가 속해 있는 클래스의 인스턴스를 생성하고
        //생성된 인스턴스이름.인스턴스멤버메서드이름() 으로 호출
        SharedAndInstance obj = new SharedAndInstance();
        obj.InstanceMember();
    }
}
