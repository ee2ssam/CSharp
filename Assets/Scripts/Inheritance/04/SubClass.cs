using UnityEngine;

namespace Inheritance04
{
    //자식 클레스
    public class SubClass : BaseClass   // : (콜론)으로 부모 클레스 지정
    {
        public void PrintDebug()
        {
            base.PrintLog(); // base 키워드로 부모 멤버에 접근한다
        }
    }
}
