using UnityEngine;
using System.Collections;

//[1]네임스페이스: 클레스 이름 충돌 방지, 같은 성격, 비슷한 기능의 클레스를묶어서 관리
namespace InterfaceTest
{
    //[2]인터페이스: 공통 기능 모아서 클래스 설계, 다중 상속 가능
    public interface IStandard
    {
        void Run(); //공통기능- 메서드 지정, 상속받은 자식클레스에서 구현하도록 강제
    }

    //[3]클래스: 인스턴스(실체)를 찍어낼수 있게 만드는 설계도
    public class Car : IStandard
    {
        //[4]필드: 멤버변수, 전역변수, private이 기본
        #region Field
        private string name;    //전역 변수
        private string[] names; //배열
        private readonly int _Length;    //읽기전용 필드
        #endregion

        //[5]생성자: 필드(멤버변수) 초기화
        #region Construct
        public Car()
        {
            this.name = "좋은 차";
        }

        public Car(string _name)
        {
            this.name = _name;
        }

        public Car(int length)
        {
            this.name = "좋은 차";
            _Length = length;        //읽기 전용 필드는 생성자 안에서 초기화 가능
            names = new string[_Length];
        }
        #endregion

        //[6]메서드: 멤버 메서드 
        #region Method
        public void Run()
        {
            Debug.Log($"{name}가 달립니다");
        }
        #endregion

        //[7]속성: 기본이 public - private 필드를 외부에 공개
        #region Property
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Length
        {
            get { return _Length; }
        }
        #endregion

        //[8]소멸자: 객체가 소멸될때 호출
        #region Distruct
        ~Car()
        {
            Debug.Log($"{name}가 폐차됨");
        }
        #endregion

        //[9]인덱서, 이터레이터(반복기)
        #region Indexer
        public string this[int index]
        {
            get { return names[index]; }
            set { names[index] = value;  }
        }
        //반복기
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _Length; i++)
            {
                yield return names[i];
            }
        }
        #endregion

        //[10]대리자
        #region Delegate
        public delegate void EventHandler();

        //이벤트
        public event EventHandler Click;
        public void OnClick()
        {
            if(Click != null)
            {
                Click.Invoke();
            }
        }
        #endregion
    }


}