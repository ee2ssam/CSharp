using UnityEngine;

public class ExceptionDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string inputNumber = "3.14";
        int number = 0;

        try
        {
            number = System.Convert.ToInt32(inputNumber);
            Debug.Log($"입력한 값은: {number}");
        }
        catch (System.Exception ex)
        {
            Debug.Log(ex.Message);
        }

        /*catch (System.FormatException fe)
        {
            Debug.Log(fe.Message);
            Debug.Log($"{inputNumber}는 정수이어야 합니다");
        }*/
    }
}
