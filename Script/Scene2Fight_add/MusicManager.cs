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
    string textStringValue;
    bool checktext;

    void Update()
    {
        CheckInputData();

    }
    /// <summary>
    /// �Է°� Ȯ��
    /// </summary>
    void CheckInputData()
    {
        if (checktext == false && musicNodeBackground.transform.GetChild(6).GetChild(0).GetComponent<TMP_Text>().text!="")
        {
            
            for (int index = 0; index < 7; index++)
            {
                textStringValue += musicNodeBackground.transform.GetChild(index).GetChild(0).GetComponent<TMP_Text>().text;
               
                checktext = true;
            }
            Debug.Log($"{textStringValue} \n ");
        }
        
    }
   
}
