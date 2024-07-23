using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    [Header("���� ��� ��ũ ũ��")]
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



    List<GameObject> cirList;//���� Ÿ�̹� ���
    List<GameObject> textCirList;//�ؽ�Ʈ ���

    [SerializeField] float speed;

    [SerializeField] List<GameObject> soundGameObj;
    [SerializeField] GameObject musicNodeBackground;
    string textStringValue;
    bool checktext;
    /// <summary>
    /// ó�� ��� ��ü �Է�
    /// </summary>
    void cirStartListInpuit()
    {
        for (int x =0;x <7;x++)
        {
            cirList[x] = musicNodeBackground.transform.GetChild(x).GetChild(1).gameObject;
            textCirList[x] = musicNodeBackground.transform.GetChild(x).GetChild(0).gameObject;
        }
    }
    void Start()
    {
        cirStartListInpuit();        
    }

    void Update()
    {
        CirScaleTimer();
        CheckInputData();

    }
    /// <summary>
    /// Ÿ�ֿ̹� ���缭 
    /// </summary>
    void CirScaleTimer()
    {
        musicSize[0]
        //musicSize[]




        for (int index=0;index<7;index++)
        {
            if (cirList[index].transform.localScale.x<1)
            {

            }
            
        }
        



        /*if (oncir && cirTimer > 0f)
        {
            //0~1�ʻ��� Ÿ�ֿ̹� ���缭 ���𰡸� �Է��ߴٸ�
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
    /// �Է°� Ȯ��
    /// </summary>
    void CheckInputData()
    {
        //�������� �ִ°��� ������������鼭 ó�� �̶��!
        if (checktext == false &&textCirList[6].GetComponent<TMP_Text>().text!="")
        {
            
            for (int index = 0; index < 7; index++)
            {
                //�Է°��� x���ƴҰ�� ��� �ؽ�Ʈ�� ���Է�   
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
