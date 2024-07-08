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
        //어처피 애니메이션에 xy같이 움직이니 x만조절함
        //사이즈가 0~1일때 입력하면 성공 그게아니면 실패
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
