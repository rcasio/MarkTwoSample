using UnityEngine;
using System.Collections;

// 동적으로 변하는 데이터 테이블 (정적인 테이블은 namespace를 사용하지 않는다.)
namespace DynamicTable
{   
    [System.Serializable]
    public class Stats
    {
        // 기본 스탯
        public int STR;
        public int CON;
        public int DEX;
        public int INT;
        public int CHA;
        public int MEN;
        
        // 세부 스탯
        public int HP;
        public int Mana;
        public int Speed;
        public int Aming;
        public float Discount;
        public int PhysicATK;
        public int FireATK;
        public int FrostATK;
        public int PoisonATK;
        public int PhysicDEF;
        public int FireDEF;
        public int FrostDEF;
        public int PoisonDEF;
        public float CriticalPRO;
        public float FlamePRO;
        public float FreezingPRO;
        public float SlowPRO;
        public float SleepPRO;
        public float PoisoningPRO;
        public float FearPRO;
        public float CharmPRO;
        public float MentalCollapsePRO;
        public float CriticalREG;
        public float FlameREG;
        public float FreezingREG;
        public float SlowREG;
        public float SleepREG;
        public float PoisoningREG;
        public float FearREG;
        public float CharmREG;
        public float MentalCollapseREG;
    }
}

