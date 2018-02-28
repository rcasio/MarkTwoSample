using UnityEngine;
using System.Collections;

public class OptionManager : MonoBehaviour {

	public enum Language { None ,Kor, Eng, Jpn }
    public Language language;

    void Awake()
    {
        // TODO : 기기 설정에 따른 언어설정을 하도록 한다.
        language = Language.Kor;
    }
}
