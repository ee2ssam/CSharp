using UnityEngine;

namespace InheritanceFieldTest
{
    //부모 클래스
    public class BaseClass
    {
        //[1]필드 선언 - 접근제한자 기본적으로 private
        private string word;

        //[2]속성 : private한 필드에는 상속받은 자식클래스만 접근 가능
        protected string Word
        {
            get {  return word; }
            set { word = value; }
        }

    }
}
