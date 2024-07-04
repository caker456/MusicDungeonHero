using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select_playerjob : MonoBehaviour
{
    bool firstin=false;
    [SerializeField] public List<GameObject> selectPlayerJob;
    int[] checknum = new int[3];
    void OnEnable()
    {
        InitJobSelect();
        RandomJob();
        
    }
    /// <summary>
    /// 직업 랜덤3개 측정
    /// </summary>
    void RandomJob()
    {
        //변수 랜덤입력
        for (int indexa = 0; indexa < 3; indexa++)
        {
            checknum[indexa] = Random.Range(0, selectPlayerJob.Count);

        }
        CheckRandomJob();



    }
    /// <summary>
    /// 랜덤변수 겹치는거없이 사용하는함수
    /// </summary>
    void CheckRandomJob()
    {
        for (int indexa = 0; indexa < 3; indexa++)
        {
            for (int indexb = 0; indexb < 3; indexb++)
            {
                //같은자리는 확인없이 다른자리확인 해서 겹치는게있으면 다시 함수불러와서 랜덤돌리기
                if (indexa!=indexb &&checknum[indexa] == checknum[indexb])
                {
                    RandomJob();
                }
            }

        }
        inputdata();
           
    }
    /// <summary>
    /// 화면에 보이게 출력
    /// </summary>
    void inputdata()
    {
        for (int i  = 0; i<3; i++)
        {
            selectPlayerJob[checknum[i]].SetActive(true);
            firstin = true;
        }
        
    }
    void InitJobSelect()
    {
        if (firstin)
        {
            for (int i = 0; i < 3; i++)
            {
                selectPlayerJob[checknum[i]].SetActive(false);
            }
            firstin = false;
        }
    }
}
