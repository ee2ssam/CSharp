//[1] 네이스페이스 
using UnityEngine;
using System.Collections;

//[1] 네임스페이스 정의 : 클래스명 충돌 방지
namespace Oop
{
    //[2] 인터페이스 : 상속받은 클래스가 구현해야 할 기능들을 정의(설계, 표준), 다중 상속 가능
    public interface IStandard
    {
        //기능 정의
        void Run();
    }

    /// <summary>
    /// [3] 클래스 : 설계도
    /// </summary>
    public class Car : IStandard
    {
        #region [4] 필드(전역변수, 멤버변수) : Private, Member, Variable
        private string name;    //이름을 저장하는 전역변수, 부품
        private string[] names; //배열열 필드
        private readonly int _Length;   //읽기 전용 필드
        #endregion

        #region [5] 생성자(Contructor) : 필드 초기화
        public Car()
        {
            this.name = "좋은 차";
        }

        public Car(string name)
        {
            this.name = name;
        }

        public Car(int length)
        {
            this.Name = "좋은 차";     //속성을 통해 필드 초기화
            _Length = length;         //생성자안에서는 읽기 전용 필드의 초기화가 가능하다
            names = new string[length]; //입력받은 매개변수 길이로 배열 요소수 생성
        }
        #endregion

        #region [6] 메서드(Method) : 기능/동작, private, public
        public void Run() => Debug.Log($"{this.name} 자동차가 달립니다");
        #endregion

        #region [7] 속성 : private한 필드 => 외부공개, public 속성
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Length
        {
            get { return this._Length; }
        }
        #endregion

        #region [8] 소멸자(Destructor) : 생성된 객체가 소멸될때 마지막으로 호출
        ~Car()
        {
            Debug.Log($"{this.name} 자동차가 폐차됨");
        }
        #endregion

        #region [9] 인덱서(Indexer) 
        public string this[int index]
        {
            get { return names[index]; }
            set { names[index] = value; }
        }
        #endregion

        #region [10] 이터레이터(Iterators) : 반복기, 인덱서를 foreach문에서 사용가능하도록 함
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _Length; i++)
            {
                yield return names[i];
            }
        }
        #endregion

        #region [11] 대리자(Delegate) : public, 다중 메서드 호출 가능
        public delegate void EventHandler();
        #endregion

    }

    public class OopPractice : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[A] 클래스의 인스턴스 생성, 메서드 호출
            Car campingCar = new Car("캠핑카");
            campingCar.Run();                   //캠핑카 자동차가 달립니다

            //[B] 속성
            Car sportsCar = new Car();
            sportsCar.Name = "스포츠카";
            sportsCar.Run();                    //스포츠가 달립니다

            //[C] 인덱서
            Car cars = new Car(2);
            cars[0] = "1번 자동차";
            cars[1] = "2번 자동차";
            for (int i = 0; i < cars.Length; i++)
            {
                Debug.Log(cars[i]);
            }

            //[D] 반복기
            foreach (var car in cars)
            {
                Debug.Log(car);
            }

            //[E] 대리자
        }
    }
}