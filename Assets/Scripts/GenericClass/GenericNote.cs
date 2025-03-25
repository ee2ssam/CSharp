using UnityEngine;

namespace GenericClass
{
    //형식 매개변수 T에 지정한 형식으로 클래스와 멤버의 성질이 결정되는 클래스
    public class GenericNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Cup 클래스의 인스턴스(객체) 생성
            //Cup cup = new Cup();
            //[1] T에 string을 지정하여 문자열을 저장하는 속성 생성
            Cup<string> text = new Cup<string>();
            text.Content = "문자열";
            //text.Content = 1234;

            //[2] T에 int을 지정하여 정수형 숫자를 저장하는 속성 생성
            Cup<int> number = new Cup<int>();
            number.Content = 1234;
            //number.Content = "abc";

            Debug.Log($"{text.Content} - {number.Content}");

            //[3] T에 Water(사용자정의 데이터 형식)를 지정하면 물을 저장하는 속성 생성
            Cup<Water> water = new Cup<Water>();
            water.Content = new Water();
            Debug.Log(water.Content.ToString());

            Cup<Coffee> coffee = new Cup<Coffee>();
            coffee.Content = new Coffee();
            coffee.PrintData(coffee.Content);
        }
    }
}



