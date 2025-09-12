using UnityEngine;

//학생들의 성적을 관리하는 구조체 - 중첩 구조체 이용
struct Student
{
    public int number;  //번호
    public string name; //이름
    public Score scores;    //중첩 구조체
}

//과목별 점수를 관리하는 구조체
struct Score
{
    public int kor;
    public int eng;
}



public class StructurePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]구조체 사용 - 배열 변수 선언, 요소수 생성
        Student[] s = new Student[3];

        //구조체 변수들 초기화
        s[0].number = 1;
        s[0].name = "홍길동";
        s[0].scores.kor = 100;
        s[0].scores.eng = 90;

        s[1].number = 2;
        s[1].name = "백두산";
        s[1].scores.kor = 90;
        s[1].scores.eng = 85;

        s[2].number = 3;
        s[2].name = "임꺽정";
        s[2].scores.kor = 98;
        s[2].scores.eng = 80;

        //사용 - 학생 성적표 출력
        for (int i = 0; i < s.Length; i++)
        {
            Debug.Log($"{s[i].number}-{s[i].name} : 국어 {s[i].scores.kor}점, 영어 {s[i].scores.eng}점 ");
        }

    }
}
