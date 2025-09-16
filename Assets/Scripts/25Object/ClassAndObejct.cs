using UnityEngine;

//개체, 객체, 오브젝트 : 설계도인 클래스로부터 만들어진 하나의 인스턴스(실체, 구성 요소)

//[1] ClassCode 이름의 클래스(Class) 만들기
public class ClassCode
{
    //Empty
}


public class ClassAndObejct : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] 특정 클래스(ClassCode)의 개체(오브젝트) 만들기, 인스턴스 생성
        // ClassCode 인스턴스를 objectCode1 이름으로 생성
        ClassCode objectCode1 = new ClassCode();
        Debug.Log(objectCode1.GetHashCode());

        //ClassCode 인스턴스를 objectCode2 이름으로 생성
        ClassCode objectCode2 = new ClassCode();
        Debug.Log(objectCode2.GetHashCode());

    }
}
