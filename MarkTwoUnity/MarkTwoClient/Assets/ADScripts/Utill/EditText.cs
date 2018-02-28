using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Text;

// 텍스트를 편집합니다. 인게임에서 텍스트를 출력할 때는 반드시 EditText 클래스를 사용해야 합니다.
public class EditText : MonoBehaviour {
    
	static StringBuilder edit_string = new StringBuilder();
	
	// 문자열을 편집할 때 사용됩니다.
	static public string AddString(params string[] string_List){
		
		// 유니티에서는 Clear() 함수를 지원하지 않는다.
		edit_string.Remove(0,edit_string.Length);
		
		int i = 0;
		int length = string_List.Length;
		
		while( i < length ) {
			if( string.IsNullOrEmpty( string_List[i] ) == false ) {
				edit_string.Append(string_List[i]);
			}
			i++;
		}
		return edit_string.ToString();
	}

    // 스트링 값에 따라 설정된 언어가 출력됩니다. 테이블에 값이 없을 경우 "Null"이 출력됩니다.
    static public string Text(int stringNumber )
    {
        string txt = null;

        SystemLanguage currentLanguage = MultilingualManager.Instance.currentLanguage; // 현재 사용하는 언어

        switch (currentLanguage)
        {
            case SystemLanguage.Afrikaans:
                break;
            case SystemLanguage.Arabic:
                break;
            case SystemLanguage.Basque:
                break;
            case SystemLanguage.Belarusian:
                break;
            case SystemLanguage.Bulgarian:
                break;
            case SystemLanguage.Catalan:
                break;
            case SystemLanguage.Chinese:
                break;
            case SystemLanguage.Czech:
                break;
            case SystemLanguage.Danish:
                break;
            case SystemLanguage.Dutch:
                break;
            case SystemLanguage.English:
                txt = Table.Multilingual[stringNumber].Eng;
                break;
            case SystemLanguage.Estonian:
                break;
            case SystemLanguage.Faroese:
                break;
            case SystemLanguage.Finnish:
                break;
            case SystemLanguage.French:
                break;
            case SystemLanguage.German:
                break;
            case SystemLanguage.Greek:
                break;
            case SystemLanguage.Hebrew:
                break;
            case SystemLanguage.Icelandic:
                break;
            case SystemLanguage.Indonesian:
                break;
            case SystemLanguage.Italian:
                break;
            case SystemLanguage.Japanese:
                txt = Table.Multilingual[stringNumber].Jpn;
                break;
            case SystemLanguage.Korean:
                txt = Table.Multilingual[stringNumber].Kor;
                break;
            case SystemLanguage.Latvian:
                break;
            case SystemLanguage.Lithuanian:
                break;
            case SystemLanguage.Norwegian:
                break;
            case SystemLanguage.Polish:
                break;
            case SystemLanguage.Portuguese:
                break;
            case SystemLanguage.Romanian:
                break;
            case SystemLanguage.Russian:
                break;
            case SystemLanguage.SerboCroatian:
                break;
            case SystemLanguage.Slovak:
                break;
            case SystemLanguage.Slovenian:
                break;
            case SystemLanguage.Spanish:
                break;
            case SystemLanguage.Swedish:
                break;
            case SystemLanguage.Thai:
                break;
            case SystemLanguage.Turkish:
                break;
            case SystemLanguage.Ukrainian:
                break;
            case SystemLanguage.Vietnamese:
                break;
            case SystemLanguage.ChineseSimplified:
                break;
            case SystemLanguage.ChineseTraditional:
                break;
            case SystemLanguage.Unknown:
                break;
            case SystemLanguage.Hungarian:
                break;
            default:
                break;
        }

        if (string.IsNullOrEmpty(txt))
        {
            Debug.LogError("Text_Languages 테이블에 " + stringNumber + "넘버를 검색할 수 없습니다.");
            Debug.LogError("만얀 데이터가 정상 입력되어 있다면 마지막 필드 값이 입력되어 있는지 확인바랍니다.(버그로 인해 마지막 필드값이 입력되어야 데이터가 읽혀짐");
        }

        return txt;
    }
}
