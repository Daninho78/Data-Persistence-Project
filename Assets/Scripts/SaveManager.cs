using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class SaveManager : MonoBehaviour
{
    public static SaveManager Instance;
    public string userName;
    public int bestScore;
    public string bestScoreName;

    public void Awake()
    {
       if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    [System.Serializable]

    class SaveData
    {
        public string bestScoreName;
        public int bestScore;
    }
        public void SaveBestScore()
        {
            SaveData data = new SaveData();
            data.bestScoreName = bestScoreName;
            data.bestScore = bestScore;

            string json = JsonUtility.ToJson(data);

            File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
        }
    
    public void LoadBestScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";

        if(File.Exists(path))
        {
            string json = File.ReadAllText(path);

            SaveData data = JsonUtility.FromJson<SaveData>(json);

            bestScoreName = data.bestScoreName;
            bestScore = data.bestScore;
        }
    }


}
