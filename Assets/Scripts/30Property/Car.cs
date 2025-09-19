using UnityEngine;

namespace Property
{
    //자동차의 상태를 관리하는 클래스
    public class Car
    {
        //필드
        private string color;

        //인스턴스 생성시 생성자를 통해 필드 초기화
        //생성자
        public Car()
        {
            this.color = "Black";
        }

        //private한 color(필드)를 public한 메서드를 이용하여 외부에서 읽기, 쓰기
        public void SetColor(string _color)
        {
            this.color = _color;
        }

        public string GetColor()
        {
            return this.color;
        }

        //private한 color(필드)를 public한 속성(property)을 이용하여 외부에서 읽기, 쓰기
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        //읽기 전용 속성
        public string Maker
        {
            get
            {
                return "현대자동차";
            }
        }

        //Auto, 축약형
        public string Name { get; set; }


    }
}