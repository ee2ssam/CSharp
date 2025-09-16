using UnityEngine;
using System.Linq;

public class LingCount2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //불형 배열 변수 선언 및 요소수 생성
        bool[] blns = { true, false, true, false, true };

        //전체 요소수의 갯수
        Debug.Log(blns.Count());    //5

        //true 갯수가 몇개인지?
        Debug.Log(blns.Count(b => b == true));    //3

        //false 갯수?
        Debug.Log(blns.Count(a => a == false));    //2
    }

}
