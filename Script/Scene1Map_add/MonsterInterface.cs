using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonsterInterface : MonoBehaviour
{
    
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
            SceneManager.LoadScene("Fight");
            Debug.Log("11");
        
    }

    // Update is called once per frame

}
