using UnityEngine;

//열거형은 switch문과 함께 많이 사용되어진다
//한글 동물 이름 출력하기
enum Animalw
{
    Chicken,
    Dog,
    Pig
}


public class EnumSwitch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //열거형 변수 선언, 초기화
        Animalw ani = Animalw.Dog;
        PrintAnimal(ani);
    }

    //매개변수로 열거형 변수를 받아 한글 이름 출력하기
    void PrintAnimal(Animalw animal)
    {
        switch(animal)
        {
            case Animalw.Chicken:
                Debug.Log("닭");
                break;
            case Animalw.Dog:
                Debug.Log("개");
                break;
            case Animalw.Pig:
                Debug.Log("돼지");
                break;
        }
    }


}
