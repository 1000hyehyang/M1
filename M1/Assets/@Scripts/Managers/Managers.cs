using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// singleton으로 모든 기능 관리
public class Managers : MonoBehaviour
{
    /* 유니티에서는 오브젝트를 판 다음에 컴포넌트라는 부품을 붙여줘야 적용이 됨. 비로소 코드가 활성화되는 것임.
     * 그 작업을 일일이 hierachy 창에서 하는 게 아니라 아래 코드로 생성해주는 것임 */

    private static Managers s_instance;
    private static Managers Instance {  get { Init();  return s_instance; } }


    public static void Init() 
    {
        if (s_instance == null)
        {
            GameObject go = GameObject.Find("@Managers");
            if (go != null)
            {
                go = new GameObject { name = "@Managers" };
                go.AddComponent<Managers>();
            }

            DontDestroyOnLoad(go);

            // 초기화
            s_instance = go.GetComponent<Managers>();
        }
    }
}
