using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickButton : MonoBehaviour
{
    string jobname_Image;
    int[] jobcount = new int[4];
    int jobnamepointer = 0;
    int pointer=0;
    Image jobimage;
    [SerializeField] List<GameObject> Inv;
    [SerializeField] GameObject selectjob;

    public void OnClickToJob()
    {
        jobname_Image = selectjob.transform.GetChild(jobnamepointer).name + "_Image";
        Debug.Log(jobname_Image);
        jobimage = GameObject.Find(jobname_Image).GetComponent<Image>();
        if (pointer<4)
        {
            Inv[pointer].GetComponent<Image>().sprite = jobimage.sprite;
            pointer++;
            
        }
        selectjob.SetActive(false);
       // CheckJobInv();
    }


    void CheckJobInv()
    {

    }

  /// <summary>
  /// ��ư��Ŭ�������� ����
  /// </summary>
    public void Magic()
    {
        jobnamepointer = 0;
        OnClickToJob();
    }
    public void Sword()
    {
        jobnamepointer = 1;
        OnClickToJob();
    }
    public void Healer()
    {
        jobnamepointer = 2;
        OnClickToJob();
    }
    public void Hunter()
    {
        jobnamepointer = 3;
        OnClickToJob();
    }
    public void Paladin()
    {
        jobnamepointer = 4;
        OnClickToJob();
    }
    public void Sheild()
    {
        jobnamepointer = 5;
        OnClickToJob();
    }
    public void Wooder()
    {
        jobnamepointer = 6;
        OnClickToJob();
    }



  
}
