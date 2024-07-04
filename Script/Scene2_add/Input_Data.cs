using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Input_Data : MonoBehaviour
{
    string inputdata_s="";
    float timerinput=3f;
    [SerializeField] List<GameObject> listTextGameobj;
    int index = 0;
    //qwer입력
    void InputDataQWER()
    {
        timerinput -= Time.deltaTime;
        //3초이상지낫으면 초기화시키면서 
        if (timerinput < 1f)
        {
            Debug.Log("1초사이 함수실행");
            k();
        }
        else if (timerinput<0f)
        {
            timerinput = 3;
        }
        else
        {

        }
        index++;

       
    }
    void k()
    {
        Debug.Log("함수들어옴");
        if (Input.GetKeyDown(KeyCode.Q))
        {
            inputdata_s = "Q";
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            inputdata_s = "W";
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            inputdata_s = "E";
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            inputdata_s = "R";
        }
        else
        {

        }
        Debug.Log(inputdata_s);
    }
    //
    void inputlooking()
    {


        if (inputdata_s!="" || inputdata_s != null)
        {
            Debug.Log(inputdata_s);
            //listTextGameobj[index].transform.GetChild(0).GetComponent<TextMeshPro>().text = inputdata_s;
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(timerinput);
        InputDataQWER();
    }
}
