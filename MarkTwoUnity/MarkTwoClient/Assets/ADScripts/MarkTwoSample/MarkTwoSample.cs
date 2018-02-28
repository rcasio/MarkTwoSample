using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarkTwoSample : MonoBehaviour {

    [Header("[아이템 코드]")]
    public int itemNum;

    [Header("[NPC 코드]")]
    public int npcCode;

    [Header("[라벨]")]
    public Text tableVersion;
    
    public Text npcName;
    public Text npcTableNum;
    public Text npcLevel;
    public Text npcExp;
    public Text npcHP;

    public Text itemName;
    public Text itemTableNum;
    public Text itemPrice;
    
    private void Awake()
    {
        new TableLoad();
        
        Debug.Log("테이블 버전 : " + TagManager.Table.PR.TableVersion);
    }

    void Start()
    {
        this.Initialization();
    }

    private void Initialization()
    {
        // 테이블 버전
        tableVersion.text = EditText.AddString("테이블 버전  " , TagManager.Table.PR.TableVersion.ToString());
        
        // NPC
        int npcNum = npcCode;
        this.npcName.text = EditText.Text(Table.NPC[npcNum].Num);
        this.npcTableNum.text = EditText.AddString(npcNum.ToString());
        this.npcLevel.text = EditText.AddString("Level : ", Table.NPC[npcNum].Level.ToString());
        this.npcExp.text = EditText.AddString("Exp : ", Table.NPC[npcNum].Exp.ToString());
        this.npcHP.text = EditText.AddString("HP : ", Table.NPC[npcNum].HP.ToString() );

        // 아이템
        this.itemName.text = EditText.Text(Table.Item[itemNum].Num);
        this.itemTableNum.text = EditText.AddString(npcNum.ToString());
        this.itemPrice.text = EditText.AddString("아이템 가격 : ", Table.Item[itemNum].Buy.ToString());
    }
}
