using UnityEngine;

//문자 비교식 예제
//입력 받은 알파펫 문자의 대문자, 소문자 판별
public class CharDemo : MonoBehaviour
{
    //캐릭터 문자 변수 선언하고 초기화
    public char c = 'a';

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //대문자, 소문자 판별
        if(c >= 'A' && c <= 'Z')
        {
            Debug.Log($"{c}는 대문자 입니다");
        }
        else //'A'와 'Z' 사이에 없으면
        {
            Debug.Log($"{c}는 소문자 입니다");
        }
    }
}
