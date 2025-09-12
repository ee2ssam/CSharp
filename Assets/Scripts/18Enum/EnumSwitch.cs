using UnityEngine;

//동물들을 관리하는 enum
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
        //
        Animalw animal = Animalw.Pig;
        PrintAnimal(animal);
    }

    //열거형 Animalw의 변수를 매개변수로 받아서 한글 동물이름을 출력하는 기능 구현
    void PrintAnimal(Animalw ani)
    {
        //값을 비교해서 분기
        switch(ani)
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
