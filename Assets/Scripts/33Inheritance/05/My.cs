using UnityEngine;

namespace InheritanceBaseTest
{
    //자식 클래스
    public class My : Car
    {
        //생성자
        public My() : this("나의 자동차")
        {

        }

        public My(string _name) : base(_name)
        {

        }

    }

    //자식 클래스
    public class Your : Car
    {
        //생성자
        public Your() : base("너의 자동차")
        {

        }

    }
}

/*
// 자신(사용된 클래스) 인스턴스, 자신 생성자
this, this()

// 부모 클래스 인스턴스, 부모 생성자
base, base()



*/