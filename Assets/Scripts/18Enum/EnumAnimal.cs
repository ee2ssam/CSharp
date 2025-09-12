using UnityEngine;

//[1] enum 정의, 선언
//동물들을 구분하는 열거형
enum Animal
{
    Mouse,
    Cow,
    Tiger
}


public class EnumAnimal : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2]enum 사용 - 변수 선언하고 초기화
        Animal animal = Animal.Tiger;
        Debug.Log(animal);

        //조건문
        if(animal == Animal.Tiger)
        {
            Debug.Log("호랑이");
        }

    }
}
