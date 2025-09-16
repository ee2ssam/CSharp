using UnityEngine;

using Korea.Suwon;      //Korea.Suwon에 있는 클래스를 가져다가 사용한다
using Su = Korea.Suwon; //Korea.Suwon를 Su 네임스페이스 별칭으로 만들어 사용

public class NameSpaceNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]네임스페이스 전체를 지정해서 사용
        //서울 Car 인스턴스 생성
        Korea.Seoul.Car se = new Korea.Seoul.Car();
        se.Run();   //서울 자동차
        Korea.Suwon.Car su = new Korea.Suwon.Car();
        su.Run();   //수원 자동차

        //[2] using을 선언해서 사용
        Car seoul = new Car();
        seoul.Run();        //수원 자동차

        //[3] 네임스페이스의 별칭을 지정해서 사용
        Su.Car suwon = new Su.Car();
        suwon.Run();        //수원자동차

        //[4]
        Korea.Seoul.Truck tr = new Korea.Seoul.Truck();
        tr.Run();

    }
}
