using UnityEngine;

//break 무한 루프 빠져나가기
public class BreakWhile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //무한반복
        /*for(;;)
        {
        }*/

        int number = 0;

        //number가 5이상이면 while문 종료
        while (true)    //무한 루프
        {
            //반복 실행문
            Debug.Log(number);

            number++;
            if(number >= 5)
            {
                break;
            }
        }
    }
}
