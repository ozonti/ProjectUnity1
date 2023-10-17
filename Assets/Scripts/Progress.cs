using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class PlayerInfo
{
    public List<Texture> PhotosInfo;
    public int index = 0;
}

public class Progress : MonoBehaviour
{

    public PlayerInfo PlayerInfo;

    /*[DllImport("__Internal")]
    private static extern void SaveExtern(string date);

    [DllImport("__Internal")]
    private static extern void LoadExtern();*/



    public static Progress Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            transform.parent = null;
            DontDestroyOnLoad(gameObject);
            Instance = this;
            //LoadExtern();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Save()
    {
        string jsonString = JsonUtility.ToJson(PlayerInfo);
        //SaveExtern(jsonString);
    }

    public void SetPlayerInfo(string value)
    {
        PlayerInfo = JsonUtility.FromJson<PlayerInfo>(value);
    }
}


