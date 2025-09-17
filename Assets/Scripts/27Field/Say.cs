using UnityEngine;

namespace Field
{
    public class Say
    {
        //[1]필드, 멤버변수, 전역변수 선언하고 초기화
        string message = "안녕하세요";

        //[2]메서드, 함수
        public void Hi()
        {
            //필드 값 변경
            message = "반갑습니다";

            Debug.Log(message);
        }

    }
}
