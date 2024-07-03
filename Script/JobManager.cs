using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JobManager : MonoBehaviour
{
    ClickButton cb;
    [SerializeField] public List<GameObject> selectPlayerJob;
    int[] checknum = new int[3];
    void Awake()
    {
        if (cb.clickbool)
        {
            initgameobj();
        }   
            RandomJob();
        
    }
    /// <summary>
    /// ���� ����3�� ����
    /// </summary>
    void RandomJob()
    {
        //���� �����Է�
        for (int indexa = 0; indexa < 3; indexa++)
        {
            checknum[indexa] = Random.Range(0, selectPlayerJob.Count);
            Debug.Log($"{checknum[indexa]}");
        }
        CheckRandomJob();



    }
    /// <summary>
    /// �������� ��ġ�°ž��� ����ϴ��Լ�
    /// </summary>
    void CheckRandomJob()
    {
        for (int indexa = 0; indexa < 3; indexa++)
        {
            for (int indexb = 0; indexb < 3; indexb++)
            {
                //�����ڸ��� Ȯ�ξ��� �ٸ��ڸ�Ȯ�� �ؼ� ��ġ�°������� �ٽ� �Լ��ҷ��ͼ� ����������
                if (indexa!=indexb &&checknum[indexa] == checknum[indexb])
                {
                    RandomJob();
                }
            }

        }
        inputdata();
           
    }
    /// <summary>
    /// ȭ�鿡 ���̰� ���
    /// </summary>
    void inputdata()
    {
        for (int i  = 0; i<3; i++)
        {
            selectPlayerJob[checknum[i]].SetActive(true);
        }
        
    }
    /// <summary>
    /// ���� ���� ����������� �ʱ�ȭ ��Ŵ
    /// </summary>
    void initgameobj()
    {
        for (int i = 0; i < 3; i++)
        {
            selectPlayerJob[checknum[i]].SetActive(false);
        }
    }
}
