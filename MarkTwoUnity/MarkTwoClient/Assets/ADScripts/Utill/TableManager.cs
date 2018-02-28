using UnityEngine;
using System.Collections;
using System.Reflection;
using System.Collections.Generic;
using System;
using System.Linq;

public class TableManager : SingletonMonoBehaviour<TableManager> {

    // 키워드를 사용해서 테이블 번호를 가져온다.
    public void GetTableNum(string key) 
    {
        Table.PR.OrderBy(p => p.Value.Value);
        Debug.Log(Table.PR.Select(p => p.Value.Key = "TableVersion"));
    }
}
