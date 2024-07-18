using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataJson : MonoBehaviour
{
    public string filePath = "Assets/Resources/node.json";
    void LoadJsonData()
    {
        string jsonContent = File.ReadAllText(filePath);
        ObjectRootData obrd = JsonUtility.FromJson<ObjectRootData>(jsonContent);
        foreach(ObjectData objectData in obrd.command)
        {
            Debug.Log(JsonUtility.ToJson(objectData));
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