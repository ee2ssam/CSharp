using UnityEngine;
using System.Collections.Generic;

//Dictionary 제네릭 클래스: key, value
public class DictinaryDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] Dictionary 제네릭 클래스의 인스턴스 만들기 : IDictionary 인터페이스로 받기
        IDictionary<string, string> datas = new Dictionary<string, string>();

        //[2] 데이터 입력
        datas.Add("도", "경기도");
        datas.Add("시", "수원시");

        //[3] 데이터 삭제
        datas.Remove("도");

        //[4] 데이터 입력 - 인덱서를 이용하여 데이터 입력
        datas["구"] = "장안구";

        //[5] 키 값 중복 : 에러 발생
        try
        {
            datas.Add("구", "강동구");
        }
        catch (System.Exception ex)
        {
            Debug.Log(ex.Message);
        }

        //[6] 사용
        foreach (KeyValuePair<string, string> item in datas)
        {
            Debug.Log($"{item.Key} - {item.Value}");
        }

        //[7] 인덱서를 이용해서 데이터 사용
        Debug.Log(datas["시"]);
        Debug.Log(datas["구"]);

    }
}
