using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class JsonSaving : MonoBehaviour
{
    private PlayerData playerData;

    private string path = "";
    private string persistentpath = "";

    void Start()
    {
        CreatePlayerData();
        SetPaths();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
            SaveData();

        if (Input.GetKeyDown(KeyCode.L))
            LoadData();
    }

    private void CreatePlayerData()
    {
        playerData = new PlayerData("David", 1000, 1);
    }

    private void SetPaths()
    {
        path = Application.dataPath + Path.AltDirectorySeparatorChar + "SaveData.json";
        persistentpath = Application.persistentDataPath + Path.AltDirectorySeparatorChar + "SaveData.json";
    }

    public void SaveData()
    {
        string savepath = path;

        Debug.Log("Saving Data at " + savepath);
        string json = JsonUtility.ToJson(playerData);
        Debug.Log(json);

        using StreamWriter writer = new StreamWriter(savepath);
        writer.Write(json);
    }

    public void LoadData()
    {
        using StreamReader reader = new StreamReader(path);
        string json = reader.ReadToEnd();

        PlayerData data = JsonUtility.FromJson<PlayerData>(json);
        Debug.Log(data.ToString());
    }
}
