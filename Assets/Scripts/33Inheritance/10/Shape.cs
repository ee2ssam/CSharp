using UnityEngine;

namespace AbstractNoteTest
{
    //도형을 관리하는 추상 클래스
    //여러가지 도형(삼각형, 사각형, 원,....)들의 부모 클래스
    //도형의 면적을 구하는 추상 메서드 - 강제로 구현하도록 한다 (추상 메서드)
    public abstract class Shape
    {
        //추상 메서드
        public abstract double GetArea();
    }
}