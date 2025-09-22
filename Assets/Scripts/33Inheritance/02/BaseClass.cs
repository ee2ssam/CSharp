using UnityEngine;

namespace InheritanceBase
{
    //부모 클래스 - Base, Super
    public class BaseClass
    {
        public void Do()
        {
            Debug.Log("Base 클래스에 정의된 public 메서드");
        }

        private void Run()
        {
            Debug.Log("Base 클래스에 정의된 private 메서드");
        }
    }
}
