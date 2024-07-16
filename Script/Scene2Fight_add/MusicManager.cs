using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    [Header("���� ��� ��ũ ũ��")]
    [SerializeField]public float[] musicSize;
        public float this[int index]
    {
        get {
            return musicSize[index];
        }
        set {
            musicSize[index] = value; 
        }
    }







    [SerializeField] List<GameObject> soundGameObj;
    [SerializeField] GameObject musicNodeBackground;
    [SerializeField] GameObject startGo;
    bool[] keybool = new bool[7];
    float[] timerZeroCir = new float[7];

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
            //��������� ���� �����ִٸ�!
            if (musicNodeBackground.transform.GetChild(i).gameObject.activeSelf
                && musicNodeBackground.transform.GetChild(i).GetChild(1).gameObject.activeSelf)
            {
           //     musicNodeBackground.transform.GetChild(i).GetChild(1).transform.localScale =
           //        new Vector3(sizeCir[i], sizeCir[i], 0);

           //     MusicInputData(i);
           //     keybool[i] = true;
            }
        } 
        
    }
    void MusicInputData(int index)
    {
        timerZeroCir[index] -= Time.deltaTime;
        //��ó�� �ִϸ��̼ǿ� xy���� �����̴� x��������
        //����� 0~1�϶� �Է��ϸ� ���� �װԾƴϸ� ����
        if (musicNodeBackground.transform.GetChild(index).GetChild(1).localScale.x>0f)
        {
            //musicNodeBackground.transform.GetChild(index).GetChild(1).localScale 
           //     = new Vector3()
        }
 

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
