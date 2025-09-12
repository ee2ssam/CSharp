using UnityEngine;

//문자열 관련 메서드 : 대문자, 소문자 바꾸기
public class StringFunction : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string message = "hello World";
        Debug.Log(message);

        //대문자 변경해서 출력
        Debug.Log(message.ToUpper());

        //소문자 변경해서 출력
        Debug.Log(message.ToLower());

        //문자열 대체하기, 바꾸기
        Debug.Log(message.Replace("hello", "안녕하세요").Replace("World", "세계"));
    }
}
