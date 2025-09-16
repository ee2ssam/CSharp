using UnityEngine;

// as 연산자: ~ 형식으로 변환이 가능하면 변환, 변환이 불가능하면 null
public class AsDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        object s = "반갑습니다";
        string r1 = s as string;
        Debug.Log(r1);

        object i = 1234;
        string r2 = i as string;
        if(r2 == null)
        {
            Debug.Log("null 입니다");
        }

        object j = 5678;
        if(j is string) //j가 string형식으로 변환이 가능하냐?
        {
            string r3 = j as string;
            Debug.Log(r3);
        }
        else
        {
            Debug.Log("변환이 안됩니다");
        }

    }
}

/*




*/