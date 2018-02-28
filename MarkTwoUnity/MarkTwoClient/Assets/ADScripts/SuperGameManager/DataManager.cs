using UnityEngine;
using System.Collections;

public class DataManager : MonoBehaviour
{
    public bool isLoad = false;
    
    public void TestTableLoad()
    {
        Debug.LogWarning("테스트용 테이블 로딩 로직 가동 !! 테스트 일때만 사용해야 합니다!!!");
        
        new TableLoad();

        this.isLoad = true;

        Debug.Log("테이블 버전 : " + TagManager.Table.PR.TableVersion);
    }
}