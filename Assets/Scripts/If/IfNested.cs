using UnityEngine;

// 중첩 if문
public class IfNested : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string name = "홍길동";
        int age = 20;

        //만약 이름이 홍길동과 같으면 실행문(명령문)을 실행
        if(name == "홍길동")
        {
            //실행문 - 만약 나이가 20과 같은면 실행문 실행
            if(age == 20)
            {
                //실행문
                Debug.Log($"이름은 {name}, 나이는 {age}");
            }
        }

        /*if(name == "홍길동" && age == 20)
        {
            Debug.Log($"이름은 {name}, 나이는 {age}");
        }*/
    }
}
