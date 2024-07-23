using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataJson : MonoBehaviour
{
    public string filePath = "Assets/Resources/node.json";
    string datastring;
    void LoadJsonData()
    {
        string jsonContent = File.ReadAllText(filePath);
        ObjectRootData obrd = JsonUtility.FromJson<ObjectRootData>(jsonContent);
        foreach(ObjectData objectData in obrd.command)
        {
            Debug.Log(JsonUtility.ToJson(objectData));
            Debug.Log(obrd.command[0]);
            Debug.Log(JsonUtility.ToJson(obrd.command[0].Magic));

        }


    }
    void Start()
    {
        LoadJsonData();
    }
}
public class ObjectRootData {
    public List<ObjectData> command;
}
[System.Serializable]
public class ObjectData
{
    public string Magic;
    public string Sword;
    public string Healer;
    public string Hunter;
    public string Paladin;
    public string Sheild;
    public string Wooder;
}