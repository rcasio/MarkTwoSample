using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Text를 해당 언어에 맞게 변환한다.
// 20171016 고성규
public class MultilingualController : MonoBehaviour {

    [Header("[다국어 코드]")]
    public int code;
    
    // 텍스트 컴포넌트
    private Text targetText;

    private void Awake()
    {
        targetText = GetComponent<Text>();
    }

    private void Start()
    {
        // 해당 언어에 해당하는 Multilingual 테이블의 텍스트가 들어건다.
        if (code != 0)
        {
            targetText.text = EditText.Text(code);
        }

        targetText.font = MultilingualManager.Instance.currentFont; // 현재 폰트를 대입한다.
    }
}
