using UnityEngine;

public class CategoryClass
{
    //인스턴스 메서드
    public void Print(int i)
    {
        Debug.Log($"카테고리: {i}");
    }
}


//특정 클래스의 형식의 배열을 선언후 각 배열의 인스턴스 생성후 사용
public class ClassArray : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]클래스의 배열 생성
        CategoryClass[] categories = new CategoryClass[3];

        //[2]각각의 요소에 인스턴스 생성
        categories[0] = new CategoryClass();
        categories[1] = new CategoryClass();
        categories[2] = new CategoryClass();

        //[3]배열요소 사용
        for (int i = 0; i < categories.Length; i++)
        {
            categories[i].Print(i);
        }
    }
}
