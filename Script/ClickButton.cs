using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickButton : MonoBehaviour
{
    public static ClickButton instance;
    Image masic;
    
    [SerializeField] List<GameObject> Inv;
    [SerializeField] GameObject selectjob;
    public bool clickbool{get;set;}
    public void OnClickToMasic()
    {
        for (int i =0; i<4;i++)
        {
            if (Inv[i].transform.childCount == 0)
            {
                masic = GameObject.Find("Masic_Image").GetComponent<Image>();
                Inv[i].GetComponent<Image>().sprite = masic.sprite;
                break;
            }
        }
           selectjob.SetActive(false);
           clickbool = true;
    }
    // Start is called before the first frame update
    void Awake()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
