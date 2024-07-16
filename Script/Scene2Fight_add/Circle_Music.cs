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
    [SerializeField]bool oncir;
    float cirTimer;
    int parentnum;
    TextMeshPro tmp;
    void OnEnable()
    {
        if (transform.parent.gameObject.activeSelf)
        {
            parentnum = Int32.Parse((transform.parent.name.Substring(16, 1))) - 1;
            oncir = true;
            cirTimer = musicManager.GetComponent<MusicManager>().musicSize[parentnum];
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        CirScaleTimer();
    }
    
    void CirScaleTimer()
    {

        if (oncir && cirTimer >0f)
        {
            //0~1초사이 타이밍에 맞춰서 무언가를 입력했다면
            if (cirTimer < 1f)
            {
                KeycodeInputData();
            }
            Debug.Log(cirTimer);
            transform.localScale = new Vector3(cirTimer, cirTimer, 0f);
            cirTimer -= Time.deltaTime*speed;
            
            
        }
        else
        {
            transform.localScale = Vector3.zero;
            oncir = false;
            gameObject.SetActive(false);
        }
    }
    //입력값이 뭔지
    void KeycodeInputData()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("q입력");
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("W입력");
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E입력");
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("R입력");
        }
    }
}
