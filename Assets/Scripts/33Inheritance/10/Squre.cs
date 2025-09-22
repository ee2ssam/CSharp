using UnityEngine;

namespace AbstractNoteTest
{

    //Shape(추상 클래스)를 상속받는 정사각형을 관리하는 자식클래스
    //Shape 지정하는 추상메서드(GetArea())를 구현 해야한다
    public class Squre : Shape
    {
        //필드
        private int size;   //가로,세로 길이

        //생성자 - 매개변수를 입력받아 필드 초기화
        public Squre(int _size)
        {
            this.size = _size;
        }

        //추상메서드 구현
        public override double GetArea()
        {
            return size * size;
        }
    }
}