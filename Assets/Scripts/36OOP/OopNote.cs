using UnityEngine;

namespace Oop
{
    //[1]추상클래스: 
    public abstract class Animal
    {
        //추상메서드
        public abstract string Cry();
    }

    //[2] Dog 클래스
    public class Dog : Animal
    {
        public override string Cry() => "멍멍멍";
    }

    //[3] 고양이 클래스
    public class Cat : Animal
    {
        public override string Cry() => "야옹";
    }

    //[4] 트레이너 클래스
    public class Trainer
    {
        //매개변수로 입력 받은 동물을 울게 한다
        public void DoCry(Animal animal)
        {
            //animal? Dog, Cat
            Debug.Log(animal.Cry());
        }

        /*public void DoCry(Dog dog)
        {
            //
            Debug.Log(dog.Cry());
        }

        public void DoCry(Cat cat)
        {
            //
            Debug.Log(cat.Cry());
        }*/
    }


    public class OopNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[1]기본 클래스 인스턴스 생성
            Dog dog = new Dog();
            Debug.Log(dog.Cry());

            Cat cat = new Cat();
            Debug.Log(cat.Cry());

            //[2] 부모 클래스의 이름으로 자식클래스의 인스턴스 생성 - 업캐스팅
            Animal myDog = new Dog();
            Debug.Log(myDog.Cry());

            Animal myCat = new Cat();
            Debug.Log(myCat.Cry());


            //[3]다형성
            //animal.Cry() 메서드를 호출한다
            //입력받은 매개변수에 따라서 서로 다른 유형의 기능이 실행된다
            //다형성은 메서드 오버라이딩을 통해서 구현된다
            Trainer trainer = new Trainer();
            trainer.DoCry(dog);
            trainer.DoCry(cat);

        }
    }
}

/*
다형성 : 상속(부모-자식)
: 객체(개체)를 여러가지 형식으로 읽을수 있다
: 객체(개체) 여러가지 형태로 가지고 있다
: 형식변환
업캐스팅: 자식 클래스의 인스턴스를 부모 클래스 형식으로 읽는것
다운캐스팅: 부모 클래스의 인스턴스를 자식 클래스의 형식으로 읽는것 
*/