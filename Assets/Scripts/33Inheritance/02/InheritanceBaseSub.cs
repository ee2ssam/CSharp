using UnityEngine;
using InheritanceBase;

namespace Inheritance
{
    public class InheritanceBaseSub : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Sub클래스의 인스턴스 생성
            SubClass sub = new SubClass();

            //Base 클래스에 (public, protected)정의된 메서드 모두 사용 가능하다
            sub.Do();

            // Base 클래스에 (private)정의된 메서드는 사용이 불가능하다
            //sub.Run();

        }
    }
}