using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    한국 - Spoqa-Bold
    북미, 유럽, 베트남 등 - NotoSans-Bold
    태국 - NotoSansThai-Bold
    중국(간체, 번체) - DroidSans
    일본 - Boku2-Bold

    MultilingualController를 Text 객체에 붙여 사용한다.
*/

// 다국어를 사용하기 편리하게 하기 위한 매니저
public class MultilingualManager : SingletonMonoBehaviour<MultilingualManager> {

    [Header("[폰트 리스트 - Resources의 Font를 등록한다.]")]
    public Font[] fontList; // 지원하는 폰트

    [Header("[현재 사용 폰트]")]
    public Font currentFont;

    [Header("[테스트 설정]")]
    public bool isTestMultilingue;

    [Header("[테스트 다국어 설정]")]
    public SystemLanguage testSystemLanguage;

    [Header("[현재 다국어 코드(자동할당)]")]
    public SystemLanguage currentLanguage;

    private void Awake()
    {
#if UNITY_EDITOR
        // 에디터에서 테스트용으로 설정
        if (isTestMultilingue)
        {
            Debug.LogWarning("다국어 테스트 적용");
            currentLanguage = testSystemLanguage;
        }
        else
        {
            currentLanguage = Application.systemLanguage;
        }
#endif 

        switch (currentLanguage)
        {
            case SystemLanguage.Korean:
                currentFont = fontList[0];
                break;

            case SystemLanguage.German:
                currentFont = fontList[1];
                break;

            case SystemLanguage.Russian:
                currentFont = fontList[1];
                break;

            case SystemLanguage.Spanish:
                currentFont = fontList[1];
                break;

            case SystemLanguage.English:
                currentFont = fontList[1];
                break;

            case SystemLanguage.Italian:
                currentFont = fontList[1];
                break;

            case SystemLanguage.Indonesian:
                currentFont = fontList[1];
                break;

            case SystemLanguage.Japanese:
                currentFont = fontList[4];
                break;

            case SystemLanguage.Chinese:
                currentFont = fontList[3];
                break;

            case SystemLanguage.ChineseSimplified:
                currentFont = fontList[3];
                break;

            case SystemLanguage.ChineseTraditional:
                currentFont = fontList[3];
                break;

            case SystemLanguage.Thai:
                currentFont = fontList[2];
                break;

            case SystemLanguage.Portuguese:
                currentFont = fontList[1];
                break;

            case SystemLanguage.French:
                currentFont = fontList[1];
                break;

            case SystemLanguage.Unknown:
                currentFont = fontList[1];
                break;

            default:
                currentFont = fontList[1];
                break;
        }
    }

}
