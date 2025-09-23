using UnityEngine;

namespace InterfaceNoteTest
{
    //IDog, ICat를 상속받는 클래스
    public class Pet : IDog, ICat
    {
        //명시적으로 IDog 지정
        void IDog.Eat()
        {
            Debug.Log("Dog Eat");
        }

        //명시적으로 ICat 지정
        void ICat.Eat()
        {
            Debug.Log("Cat Eat");
        }
    }
}