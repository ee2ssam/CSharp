using UnityEngine;

namespace Method
{
    public class Dog
    {
        //필드 선언부, 전역변수, 멤버변수
        public static int point = 10;
        private int weight = 20;

        //인스턴스(instance) 메서드, 함수, 멤버함수
        public void Eat()
        {
            Debug.Log("[1] 밥을 먹는다");

            Digest();
        }

        private void Digest()
        {
            Debug.Log("[2] 소화를 시킨다");
        }

        //정적(static) 메서드
        public static void Drink()
        {
            Debug.Log("[3] 물을 마신다");
        }

    }
}