using UnityEngine;

namespace Inheritance
{
    public class BaseSub : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //SubClass 클래스 인스턴스 생성
            SubClass sub = new SubClass();
            sub.Do();   //Base 클래스에 정의된 (public, protected)메서드 사용 가능
        }
    }
}