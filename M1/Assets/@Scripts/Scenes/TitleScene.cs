using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScene : BaseScene
{
    void Start()
    {
        // TitleScene 실행 시 리소스 로드
        Managers.Resource.LoadAllAsync<Object>("PreLoad", (key, count, totalCount) =>
        {
            Debug.Log($"{key} {count}/{totalCount}");

            if (count == totalCount)
            {
                // Managers.Data.Init();
            }
        });
    }

    void Update()
    {
        
    }
}
