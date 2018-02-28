// 게임의 태그를 관리한다.
namespace TagManager {

    public class GameObject
    {
        public const string Player = "Player"; // 플레이어
        public const string NPC = "NPC"; // NPC
        public const string UIManager = "UIManager"; // UI를 관리하는 매니저
    }

    public class SceneName
    {
        public const string A01_StartScene = "A01_StartScene"; // 시작 씬을 나타낸다.
        public const string A02_BattleScene01 = "A02_BattleScene01";  // 배틀스테이지를 나타낸다.
    }

    // 유니티의 레이어를 관린한다.
    public class Layer
    {
        public const string Team01 = "Team01"; // 팀 01
        public const string Team02 = "Team02"; // 팀 02
        public const string Team03 = "Team03"; // 팀 03
        public const string Team04 = "Team04"; // 팀 04
        public const string FloorCollider = "FloorCollider"; // 충돌할 층을 나타낸다.
    }

    // 좌표축을 나타낸다.
    public class Axis
    {
        public const string HorizontalPosition = "HorizontalPosition"; // 수평 포지션
        public const string VerticalPosition = "VerticalPosition"; // 수직 포지션

        public const string HorizontalRotation = "HorizontalRotation"; // 수평 회전
        public const string VerticalRotation = "VerticalRotation"; // 수직 회전
    }

    // 단위
    public class Unit
    {
        public const string StatRelate = "10000"; // 스탯에서 사용하는 상대값에서 사용되는 단위 1/10000 으로 사용된다.
    }

    // 엑셀
    public class Excel
    {
        public class PR
        {
            public const int TableVersion = 12000001; // 테이블 버전
        }
    }

    // 캐릭터 직업군 ClassStatus 테이블에 정의되어 있다.
    public class ClassCode
    {
        public const int Warrior = 1; // 워리어
    }
}

