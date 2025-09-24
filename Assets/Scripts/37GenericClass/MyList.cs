using UnityEngine;
using System.Collections;

namespace Genenric
{
    //커스텀 List<T> 만들기
    public class MyList<T>
    {
        //필드
        private T[] values;
        private int length;

        //속성
        public int Length
        {
            get { return length; }
        }

        //생성자
        public MyList(int _length)
        {
            this.length = _length;
            values = new T[length]; //T타입 요소수 생성
        }

        //인덱서
        public T this[int index]
        {
            get { return values[index]; }
            set { values[index] = value; }
        }

        //반복기
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < length; i++)
            {
                yield return values[i];
            }
        }
    }
}
