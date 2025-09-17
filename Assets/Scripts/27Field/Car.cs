using UnityEngine;

namespace Field
{
    public class Car
    {
        //필드(전역변수, 멤버변수) 선언 : public, private
        public string name;     //이름
        private int age;        //나이
        string address;         //주소, 접근제한자가 생략되어 있다, private

        //메서드(함수, 멤버함수) : public, private
        public void Hi()
        {
            Debug.Log("안녕하세요");
        }

        private void Bye()
        {
            Debug.Log("안녕히 가세요");
        }

        //private한 필드를 외부에 공개하고자 할때는 public한 메서드 만들어서 사용
        //매개변수로 정수값을 받아서 나이 값에 저장하는 함수
        public void SetAge(int value)
        {
            age = value;    //value를 나이값에 저장한다
        }

        //나이값을 반환 받는 함수
        public int GetAge()
        {
            return age; //나이 값을 반환한다
        }


    }
}
