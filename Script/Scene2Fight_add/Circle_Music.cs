using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle_Music : MonoBehaviour
{
    [SerializeField]GameObject musicManager;
    float scaleFloat;
    void OnEnable()
    {
        Debug.Log(gameObject.GetComponent<MusicManager>().musicSize[Int32.Parse((transform.parent.name.Substring(16, 1))) - 1]);
        scaleFloat = gameObject.GetComponent<MusicManager>().musicSize[Int32.Parse((transform.parent.name.Substring(16, 1)))-1];
        transform.localScale = new Vector3( scaleFloat,scaleFloat,0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
