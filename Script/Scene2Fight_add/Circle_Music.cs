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
    [SerializeField]bool oncir,onClickValueKey;//�θ� �����ִ��� Ȯ���ϴ� ���� , key�Է� Ŭ������
    float cirTimer;
    int parentnum;
    TMP_Text tmp;
    void OnEnable()
    {
        //�θ� ����Ǿ����� ����
        if (transform.parent.gameObject.activeSelf)
        {
            tmp = transform.parent.GetChild(0).GetComponent<TMP_Text>();
            parentnum = Int32.Parse((transform.parent.name.Substring(16, 1))) - 1;
            oncir = true;
            cirTimer = musicManager.GetComponent<MusicManager>().musicSize[parentnum];
        }
        
    }
    void Update()
    {
        CirScaleTimer();
    }
    //�θ� �����ִٸ�! ����
    void CirScaleTimer()
    {

        if (oncir && cirTimer >0f)
        {
            //0~1�ʻ��� Ÿ�ֿ̹� ���缭 ���𰡸� �Է��ߴٸ�
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
            onClickValueKey = false;
            gameObject.SetActive(false);
        }
    }
    //�Է°��� ����
    void KeycodeInputData()
    {
      
        if (Input.inputString != "" && Input.GetKeyDown(KeyCode.Q))
        {
            tmp.text = "Q";
            onClickValueKey = true;
            Debug.Log("q�Է�");
        }
        else if (Input.inputString != "" && Input.GetKeyDown(KeyCode.W))
        {
            tmp.text = "W";
            onClickValueKey = true;
            Debug.Log("W�Է�");
        }
        else if (Input.inputString != "" && Input.GetKeyDown(KeyCode.E))
        {
            tmp.text = "E";
            onClickValueKey = true;
            Debug.Log("E�Է�");
        }
        else if (Input.inputString != "" && Input.GetKeyDown(KeyCode.R))
        {
            tmp.text = "R";
            onClickValueKey = true;
            Debug.Log("R�Է�");
        }
        else if(Input.inputString != "")
        {
            onClickValueKey = true;
            Debug.Log("���𰡸� �Է�");
        }
    }
}
