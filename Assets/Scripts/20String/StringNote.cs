using UnityEngine;
using System;

public class StringNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //str 문자(배)열(String, char[]) 변수 선언하고 초기화
        string str = ""; //빈값으로 초기화
        str = String.Empty; //빈값으로 초기화
        str = " Abc Def Fed Cba "; //앞뒷에 공백 하나씩 주어서 값을 저장

        Debug.Log(str);
        Debug.Log(str.Length);  //문자열 길이 구하기: 17
        Debug.Log(str[5]);      //D
        Debug.Log(str.ToUpper());   //대문자 출력
        Debug.Log(str.ToLower());   //소문자 출력

        //공백 제거
        Debug.Log(str.Trim());      //앞쪽 부분에 있는 공백들, 뒤쪽 부분에 있는 공백들 제거
        Debug.Log(str.TrimStart()); //앞쪽 부분에 있는 공백만 제거
        Debug.Log(str.TrimEnd());   //뒤쪽 부분에 있는 공백만 제거

        //검색
        Debug.Log(str.IndexOf('e'));    //'e' 가 위치한 인덱스(방위치) 가져오기 6
        Debug.Log(str.Substring(5, 3)); //5번 인덱스(방위치) 부터 3글자 가져오기
        Debug.Log(str.Substring(5));    //5번 인덱스(방위치) 부터 끝까지 모두 가져오기
        Debug.Log(str.Remove(5, 3));     //5번 인덱스(방위치) 부터 3글자 삭제하기

        //비교
        Debug.Log(str[1] == str[15]);   //false
        Debug.Log("ABC".Equals("Abc")); //false
        Debug.Log(String.Compare("BAC", "Bac")); // 0(같음), 1(다름 >), -1(다름 <)

        //연결하기
        var hi1 = "안녕";
        var hi2 = "하세요";

        Debug.Log(hi1 + hi2);   // +연산
        Debug.Log($"{hi1}{hi2}");   //보간법
        Debug.Log(String.Format("{0}{1}", hi1, hi2));       //Format()
        Debug.Log(String.Format("{0:C}", 1000));            //C 통화 단위 표시
        Debug.Log(String.Format("{0:#,###}", 1000000));     //새자리 단위로 콤마 표시

        //"Abc Def Fed Cba"
        //분리하기, 전체 공백제거
        string[] strArray = str.Trim().Split(' ');
        string strAll = "";

        foreach (var item in strArray)
        {
            strAll = strAll + item;
        }

        Debug.Log(strAll);

    }
}
