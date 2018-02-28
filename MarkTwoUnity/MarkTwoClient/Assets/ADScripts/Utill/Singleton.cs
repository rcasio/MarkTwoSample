using UnityEngine;
using System;
using System.Collections;
using System.Reflection;

public class Singleton<T> where T : class, new()
{
    protected static T instance = null;
    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new T();
            }
                return instance;
        }
    }
}

public class SingletonMonoBehaviour<T> : MonoBehaviour where T : class
{
    protected static T m_Instance = null;
    public static T Instance
    {
        // get { return instance; }
        get
        {
            if (m_Instance == null)
            {
                m_Instance = FindObjectOfType(typeof(T)) as T; // 활성화 되어 있는 Type type을 넘긴다.
            }

            if (null == m_Instance) // 활성화 되어 있는 객체가 없다면
            {
                GameObject obj = new GameObject(typeof(T).Name); // 타입 이름의 객체를 생성하고
                m_Instance = obj.AddComponent(typeof(T)) as T; // 해당 타입의 컴포넌트를 붙인다.
            }

            return m_Instance;
        }
    }
}


// 씬에 정적으로 존재 하고 씬 삭제시 삭제됨.
public class SingletonDestroyMonoBehaviour<T> : MonoBehaviour where T : class
{
    protected static T m_Instance = null;
    public static T ins
    {
        // get { return instance; }
        get
        {
            if (m_Instance == null)
            {
                m_Instance = FindObjectOfType(typeof(T)) as T;
            }

            if (null == m_Instance)
            {
                GameObject obj = new GameObject(typeof(T).Name);
                m_Instance = obj.AddComponent(typeof(T)) as T;
            }

            return m_Instance;
        }
        set
        {
            m_Instance = value;
        }
    }

    protected virtual void Awake()
    {
        initial();
    }

    protected virtual void OnApplicationQuit()
    {
        m_Instance = null;
    }

    // 삭제 할때 뭔가 필요하다면 이걸 상속받아서 처리함
    protected virtual void OnDestroy()
    {
        StopAllCoroutines();
        
        m_Instance = null;
    }

    protected virtual void initial()
    {

    }
}