using UnityEngine;
using System.Collections;

//ArrayList: 리스트 컬렉션은 사용은 배열처럼 사용한다
//리스트를 생성할때 크기를 결정하지 않는다
public class ArrayListNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] ArrayList 클래스 인스턴스(객체, 개체) 생성
        ArrayList list = new ArrayList();

        //[2] 리스트에 데이터 넣기, 저장: Add()
        list.Add("강동구");
        list.Add("강남구");

        //[3] 리스트의 데이터 사용
        /*for (int i = 0; i < list.Count; i++)
        {
            Debug.Log(list[i].ToString());
        }*/

        //[4] 리스트에 데이터 넣기, Add
        list.Add(10);

        //데이터 출력
        foreach(object o in list)
        {
            Debug.Log(o.ToString());
        }
    }
}
