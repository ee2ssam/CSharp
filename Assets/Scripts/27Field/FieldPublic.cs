using UnityEngine;

namespace Field
{
    public class FieldPublic : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Categori의 객체(인스턴스) 생성
            Categori book = new Categori();

            //필드에 값 저장 (쓰기)
            book.categoriName = "책";

            //필드 사용 (읽기)
            Debug.Log(book.categoriName);
        }
    }
}