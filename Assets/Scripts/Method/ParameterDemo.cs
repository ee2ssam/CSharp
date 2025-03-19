using UnityEngine;

namespace Method
{
    public class ParameterDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //몬스터 생성
            Monster monster1 = new Monster(100, 10);
            Monster.monsterCount++;
            Monster monster2 = new Monster(200, 20);
            Monster.monsterCount++;

            //전투
            //MonsterBattle(monster2, monster1);            
            monster1.TakeDamage(monster2.atk);
            monster2.TakeDamage(monster1.atk);

            Debug.Log($"monster1 hp:{monster1.hp}, atk:{monster1.atk}");
            Debug.Log($"monster2 hp:{monster2.hp}, atk:{monster2.atk}");
            Debug.Log($"monsterCount: {Monster.monsterCount}");

        }

        //몬스터간의 1:1 전투 구현: 
        void MonsterBattle(Monster atkMonster, Monster defMonster)
        {
            defMonster.hp -= atkMonster.atk;
        }
    }

    //몬스터를 관리하는 클래스
    public class Monster
    {
        //필드
        //정적 멤버 변수: 이 프로젝트 내에서 단 하나만 존재하는 값, 공유(share)
        //이 게임에서 생성된 몬스터 총 수량을 저장
        public static int monsterCount = 0;

        //전역 변수
        public int hp;
        public int atk;

        //생성자
        public Monster(int hp, int atk)
        {
            this.hp = hp;
            this.atk = atk;
        }

        //데미지를 입는 함수
        public void TakeDamage(/*Monster this,*/ int damage)
        {
            this.hp -= damage;
        }
    }
}