using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

// 모든 씬은 이 BaseScene을 상속받음
public class BaseScene : InitBase
{
    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        Object obj = GameObject.FindObjectOfType(typeof(EventSystem));
        if(obj == null)
        {
            GameObject go = new GameObject() { name = "@EventSystem" };
            go.AddComponent<EventSystem>();
            go.AddComponent<StandaloneInputModule>();
        }

        return true;
    }
}
