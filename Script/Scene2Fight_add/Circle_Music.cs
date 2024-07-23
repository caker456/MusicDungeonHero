using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Circle_Music : MonoBehaviour
{
    [SerializeField]GameObject musicManager;
    [SerializeField] float speed;
    [SerializeField]bool oncir,onClickValueKey;//부모가 켜져있는지 확인하는 변수 , key입력 클릭변수
    float cirTimer;
    int parentnum;
    TMP_Text tmp;
    void OnEnable()
    {
        //부모가 실행되었을때 시작
        if (transform.parent.gameObject.activeSelf)
        {
            tmp = transform.parent.GetChild(0).GetComponent<TMP_Text>();
            parentnum = Int32.Parse((transform.parent.name.Substring(16, 1))) - 1;
            oncir = true;
           // cirTimer = musicManager.GetComponent<MusicManager>().musicSize[parentnum];
        }
        
    }
    void Update()
    {
        CirScaleTimer();
    }
    //부모가 켜져있다면! 시작
    void CirScaleTimer()
    {

        if (oncir && cirTimer >0f)
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
            cirTimer -= Time.deltaTime*speed;
            
            
        }
        else
        {
            transform.localScale = Vector3.zero;
            oncir = false;
            onClickValueKey = false;
            gameObject.SetActive(false);
        }
    }
    //0~1초 사이가 아닌 나머지시간에 키를입력했다면?
    void OverKeycode()
    {
            tmp.text = "X";
            gameObject.SetActive(false);
    }
    //입력값이 뭔지 확인


    void KeycodeInputData()
    {
      
        if (Input.inputString != "" && Input.GetKeyDown(KeyCode.Q))
        {
            tmp.text = "Q";
            Debug.Log("q입력");
            gameObject.SetActive(false);
        }
        else if (Input.inputString != "" && Input.GetKeyDown(KeyCode.W))
        {
            tmp.text = "W";
            Debug.Log("W입력");
            gameObject.SetActive(false);
        }
        else if (Input.inputString != "" && Input.GetKeyDown(KeyCode.E))
        {
            tmp.text = "E";
            Debug.Log("E입력");
            gameObject.SetActive(false);
        }
        else if (Input.inputString != "" && Input.GetKeyDown(KeyCode.R))
        {
            tmp.text = "R";
            Debug.Log("R입력");
            gameObject.SetActive(false);
        }
        else if(Input.inputString != "")
        {
            tmp.text = "X";
            Debug.Log("무언가를 입력");
            gameObject.SetActive(false);
            
        }
    }
}
