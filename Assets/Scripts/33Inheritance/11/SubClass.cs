using UnityEngine;

namespace InheritanceFieldTest
{
    //자식 클래스
    public class SubClass : BaseClass
    {
        //
        public void SetWord(string _word)
        {
            base.Word = _word;
        }

        public string GetWord()
        {
            return base.Word;
        }
    }
}