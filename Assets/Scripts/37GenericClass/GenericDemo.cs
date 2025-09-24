using UnityEngine;

namespace Genenric
{
    public class GenericDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Cup<T> 클래스의 인스턴스 생성
            // <T>지정은 인스턴스 생성시 지정한다
            //Cup cup = new Cup(); //에러

            //[1] T에 string을 지정하여 문자열을 저장하는 속성을 가진 인스턴스 생성
            Cup<string> text = new Cup<string>();
            text.Content = "문자열";

            //[2] T에 int을 지정하여 정수형 숫자를 저장하는 속성을 가진 인스턴스 생성
            Cup<int> number = new Cup<int>();
            number.Content = 1234;

            Debug.Log($"{text.Content} + {number.Content}");
            
            //[3] T에 Water를 지정하여 물컵을 만들어보자
            Cup<Water> water = new Cup<Water>();
            water.Content = new Water();
            Debug.Log(water.Content.ToString());

            Cup<Coffee> coffee = new Cup<Coffee>();
            coffee.Content = new Coffee();
            Debug.Log(coffee.Content.ToString());

        }
    }
}


/*
제네릭 클래스 만들기
제네릭 클래스 : 형식 매개변수 T로 지정한 형식으로 클래스와 멤버의 성질이 결정되는 클래스
Generic Class : Cup<T> 컵어브티, 전용컵
 
형식
public class 클래스이름<T>
{

}

*/
