using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    [Header("뮤직 노드 싱크 크기")]
    [SerializeField] List<float> musicSize;

    /*  [SerializeField]public float[] musicSize;
          public float this[int index]
      {
          get {
              return musicSize[index];
          }
          set {
              musicSize[index] = value; 
          }
      }*/



    GameObject[] cirList = new GameObject[7];//원형 타이밍 노드
    GameObject[] textCirList = new GameObject[7];//텍스트 노드
    float[] cirTimer = new float[7];
    [SerializeField] float speed;

    [SerializeField] List<GameObject> soundGameObj;
    [SerializeField] GameObject musicNodeBackground;
    string textStringValue;
    bool checktext;
    /// <summary>
    /// 처음 노드 객체 입력
    /// </summary>
    
    void Awake()
    {
        cirStartListInpuit();        
    }

    void Update()
    {
        CirScaleTimer();
        CheckInputData();

    }
    void cirStartListInpuit()
    {
        for (int x = 0; x < 7; x++)
        {

            cirList[x] = musicNodeBackground.transform.GetChild(x).GetChild(1).gameObject;
            textCirList[x] = musicNodeBackground.transform.GetChild(x).GetChild(0).gameObject;
            cirTimer[x] = musicSize[x];
            cirList[x].transform.localScale = new Vector3(musicSize[x], musicSize[x], 0);
        }
    }
    /// <summary>
    /// 타이밍에 맞춰서 
    /// </summary>
    void CirScaleTimer()
    {
  
        for (int x = 0; x < 7; x++)
        {
            if (cirList[x].transform.localScale.x < 1)
            {
                cirTimer[x] -= Time.deltaTime * speed;
                cirList[x].transform.localScale = new Vector3(cirTimer[x], cirTimer[x], 0);
            }
            else
            {

            }

        }


        //musicSize[]











        /*if (oncir && cirTimer > 0f)
        {
            //0~1초사이 타이밍에 맞춰서 무언가를 입력했다면
            if (cirTimer < 1f)
            {
                KeycodeInputData();
            }
            else
            {
                OverKeycode();
            }



            transform.localScale = new Vector3(cirTimer, cirTimer, 0f);
            cirTimer -= Time.deltaTime * speed;


        }*/
    }
    /// <summary>
    /// 입력값 확인
    /// </summary>
    void CheckInputData()
    {
        //마지막에 있는값이 비어있지않으면서 처음 이라면!
        if (checktext == false &&textCirList[6].GetComponent<TMP_Text>().text!="")
        {
            
            for (int index = 0; index < 7; index++)
            {
                //입력값이 x가아닐경우 결과 텍스트에 값입력   
                if (musicNodeBackground.transform.GetChild(index).GetChild(0).GetComponent<TMP_Text>().text != "X")
                {
                    textStringValue += musicNodeBackground.transform.GetChild(index).GetChild(0).GetComponent<TMP_Text>().text;
                }
                checktext = true;
            }
            Debug.Log($"{textStringValue} \n ");
        }
        
    }


}
