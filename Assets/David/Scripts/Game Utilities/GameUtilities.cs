using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public static class GameUtilities
{
    public static void SaveUserProfile(ProfileData profileData)
    {
        string json = JsonUtility.ToJson(profileData, true);

        if (!Directory.Exists(Application.dataPath + "/Profiles"))
            Directory.CreateDirectory(Application.dataPath + "/Profiles");

        SaveObject(Application.dataPath + "/Profiles/" + profileData.Email + ".json", profileData);
    }

    public static List<ProfileData> LoadUserProfiles()
    {
        string[] profiles = Directory.GetFiles(Application.dataPath + "/Profiles", "*.json");

        List<ProfileData> loadprofiles = new List<ProfileData>();

        foreach (var path in profiles)
        {
            ProfileData data = LoadObject<ProfileData>(path);

            loadprofiles.Add(data);
        }

        return loadprofiles;
    }

    public static T LoadObject<T>(string path)
    {
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            return JsonUtility.FromJson<T>(json);
        }

        else return default(T);
    }



    public static void SaveObject(string path, object objecttosave)
    {
        if (objecttosave != null)
        {
            string json = JsonUtility.ToJson(objecttosave);
            File.WriteAllText(path, json);
        }
    }

    public static void DeleteProfile(ProfileData profileDataAnnihlation)
    {
        File.Delete(Application.dataPath + "/Profiles/" + profileDataAnnihlation.Email + ".json");
    }
}
