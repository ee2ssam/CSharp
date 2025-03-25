using UnityEngine;

namespace Override
{
    public class InheritancePractice : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //HyunDai 클래스의 인스턴스 생성
            HyunDai hd = new HyunDai();
            Debug.Log($"{hd.Style}");
            hd.Go();
            hd.Back();
            hd.Left();

            HyunDai hdE = new HyunDai(CarType.전기);
            Debug.Log($"{hdE.Style}");
            hdE.Go();

            //Tesla 클래스 인스턴스 생성
            Tesla ts = new Tesla();
            Debug.Log($"{ts.Style}");
            ts.Go();
            ts.Back();
            ts.Left();


            //Mirea 클래스의 인스턴스 생성
            Mirea mr = new Mirea();
            Debug.Log($"{mr.Style}");
            mr.Go();

        }
    }
}