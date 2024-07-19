using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// singleton���� ��� ��� ����
public class Managers : MonoBehaviour
{
    /* ����Ƽ������ ������Ʈ�� �� ������ ������Ʈ��� ��ǰ�� �ٿ���� ������ ��. ��μ� �ڵ尡 Ȱ��ȭ�Ǵ� ����.
     * �� �۾��� ������ hierachy â���� �ϴ� �� �ƴ϶� �Ʒ� �ڵ�� �������ִ� ���� */

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

            // �ʱ�ȭ
            s_instance = go.GetComponent<Managers>();
        }
    }
}
