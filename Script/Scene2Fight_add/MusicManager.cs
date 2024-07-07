using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    [SerializeField] List<GameObject> soundGameObj;
    [SerializeField] GameObject musicNodeBackground;
    [SerializeField] GameObject startGo;

    void Update()
    {
        CheckStartText();

    }
    void CheckStartText()
    {
        
        if (startGo.activeSelf)
        {
            CheckInputData();
        }
    }
    void CheckInputData()
    {
        
        if (musicNodeBackground.transform.GetChild(0).gameObject.activeSelf
            && musicNodeBackground.transform.GetChild(0).GetChild(1).gameObject.activeSelf)
        {
            MusicInputData();
        }
        
    }
    void MusicInputData()
    {
        Debug.Log(musicNodeBackground.transform.Find("circle").parent.name);
        //��ó�� �ִϸ��̼ǿ� xy���� �����̴� x��������
        if (musicNodeBackground.transform.Find("circle").gameObject.activeSelf)
        {

        }

    }
}
