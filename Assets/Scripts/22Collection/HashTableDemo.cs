using UnityEngine;
using System.Collections;

public class HashTableDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] Hashtable 인스턴스(객체) 생성
        Hashtable hash = new Hashtable();

        //[2] 데이터 넣기, 저장: 정수형,문자열 인덱스를 이용, key-value
        hash[0] = "대한민국";
        hash["도이름"] = "경기도";
        hash["시이름"] = "수원시";

        //[3] 데이터 사용
        //Debug.Log(hash[0]);
        //Debug.Log(hash["도이름"]);
        //Debug.Log(hash["시이름"]);

        foreach (var o in hash.Keys)
        {
            Debug.Log($"{o.ToString()} - {hash[o]}");
        }
    }
}

/*
HashTable : HashTable 컬렉션은 데이터 입력, 데이터 사용은 배열과 같은 방법으로 한다
배열은 정수형 변수를 인덱스로 사용하는데 HashTable은 인덱스를 obejct 타입으로 한다


*/

