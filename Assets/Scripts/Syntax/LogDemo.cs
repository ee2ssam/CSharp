using UnityEngine;

public class LogDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Debug.Log("들여쓰기는 공백 4칸 또는 탭을 사용한다");
        //Debug.Log("C# 문법");

        //Debug.Log(("결과는: " + 5));       //

        //Debug.Log("결과는: " + (5 + 10));  //

        //Debug.Log("결과는: " + 5 + 10);    //

        //공백은 프로그램에서 무시
        UnityEngine.Debug.Log("C# 문법");

        Debug.  Log  (  "C# 문법"  );

        UnityEngine.Debug
            .Log(
                "C# 문법");
    }

    // Update is called once per frame
    void Update()
    {

    }

}


/*
C# Syntax(문법) : 반드시 지켜야하는 규칙
코딩 스타일 : 프로그램 작성에 대한 가이드 라인, 개발자들간의 암묵적 약속

들여쓰기(Indent) : 공백 4칸, 탭
    
    



*/