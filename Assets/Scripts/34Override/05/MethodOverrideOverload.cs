using UnityEngine;

namespace MethodOverride
{
    public class MethodOverrideOverload : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //메서드 Overloading
            Hi();
            Hi("반갑습니다");
            Hi("또 만나요", 3);

            //메서드 Override
            //부모클래스 Hi()
            ParentClass parent = new ParentClass();
            parent.Hi();

            //자식클래스 Hi()
            ChildClass child = new ChildClass();
            child.Hi();
        }

        //메서드 Overloading
        public void Hi()
        {
            Debug.Log("안녕하세요");
        }

        public void Hi(string message)
        {
            Debug.Log(message);
        }

        public void Hi(string msg, int number)
        {
            for (int i = 0; i < number; i++)
            {
                Debug.Log(msg);
            }
        }
    }
}
