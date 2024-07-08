using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    [SerializeField] List<GameObject> soundGameObj;
    [SerializeField] GameObject musicNodeBackground;
    [SerializeField] GameObject startGo;
    bool[] keybool = new bool[7];

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
        for (int i =0; i<7;i++)
        {

            if (musicNodeBackground.transform.GetChild(i).gameObject.activeSelf
                && musicNodeBackground.transform.GetChild(i).GetChild(1).gameObject.activeSelf)
            {
                MusicInputData(i);
                keybool[i] = true;
            }
        } 
        
    }
    void MusicInputData(int index)
    {
        //��ó�� �ִϸ��̼ǿ� xy���� �����̴� x��������
        //����� 0~1�϶� �Է��ϸ� ���� �װԾƴϸ� ����
        if (musicNodeBackground.transform.GetChild(index).GetChild(1).localScale.x <=1f
            && musicNodeBackground.transform.GetChild(index).GetChild(1).localScale.x>0.5f
            && Input.GetKeyDown(KeyCode.Q)
            )
        {
            soundGameObj[0].SetActive(true);   
        }
        else
        {
            soundGameObj[0].SetActive(false);
        }

    }
}
