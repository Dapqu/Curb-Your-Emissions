using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem 
{
    public static void SaveGameManager(GameManager gameManager) {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/gameManager.sag";
        FileStream stream = new FileStream(path, FileMode.Create);

        SavedData data = new SavedData(gameManager);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static SavedData LoadGameManagerData() {
        string path = Application.persistentDataPath + "/gameManager.sag";
        if (File.Exists(path)) {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            SavedData data = formatter.Deserialize(stream) as SavedData;
            stream.Close();

            return data;
        }
        else {
            Debug.Log("Save File Not Found in " + path);
            return null;
        }
    }

    public static void SaveTimer(Timer timer) {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/timer.sag";
        FileStream stream = new FileStream(path, FileMode.Create);

        SavedData data = new SavedData(timer);

        formatter.Serialize(stream, data);
        stream.Close();
    }
    
    public static SavedData LoadTimerData() {
        string path = Application.persistentDataPath + "/timer.sag";
        if (File.Exists(path)) {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            SavedData data = formatter.Deserialize(stream) as SavedData;
            stream.Close();

            return data;
        }
        else {
            Debug.Log("Save File Not Found in " + path);
            return null;
        }
    }
}