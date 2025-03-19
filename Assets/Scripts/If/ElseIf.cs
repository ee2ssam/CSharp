using UnityEngine;

public class ElseIf : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //score가 90점 이상이면 A, 80점 이상이면 B, 70점이상이면 C,
        //60점 이상이면 D, 나머지 F

        //[0]선언문
        int score = 99;
        char grade = 'A';

        //[1] score가 90점 이상이면 A
        if(score >= 90)
        {
            grade = 'A';
        }
        else if(score >= 80) //[2] 80점 이상이면 B
        {
            grade = 'B';
        }
        else if (score >= 70) //[3] 70점 이상이면 C
        {
            grade = 'C';
        }
        else if (score >= 60) //[4] 60점 이상이면 D
        {
            grade = 'D';
        }
        else //[5] 나머지 F
        {
            grade = 'F';
        }

        Debug.Log($"{grade} 학점");

    }
}
