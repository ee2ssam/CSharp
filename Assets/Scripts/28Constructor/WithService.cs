using UnityEngine;

namespace Constructor
{
    public class WithService
    {
        //필드 선언부
        //읽기 전용 필드
        private readonly string serviceName;

        //기본 생성자
        //생성자를 통해서 읽기 전용 필드도 초기화가 가능하다
        public WithService()
        {
            serviceName = "파일";
        }

        public WithService(string service)
        {
            this.serviceName = service;
        }

        //메서드
        public void Run()
        {
            Debug.Log($"{serviceName}를 실행합니다");
        }

    }
}