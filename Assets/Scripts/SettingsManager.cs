using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


public class SettingsManager : MonoBehaviour {
    public static SettingsManager Instance { get; private set; }

    public bool GameSpeedUp { get; private set; }
    public bool GameDifficultyUp { get; private set; }
    public bool GameVarietyUp { get; private set; }

    private string jsonSettingsPath;

    void Awake() {
        if (Instance != null) {
            Destroy(gameObject);
            return;
        }
        jsonSettingsPath = Application.persistentDataPath + "/rts_prototype_settings.json";
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    [System.Serializable]
    class SettingsData {
        public bool GameSpeedUp;
        public bool GameDifficultyUp;
        public bool GameVarietyUp;
    }

    public void SaveSettings(bool speedUp, bool difficultyUp, bool varietyUp) {
        var data = new SettingsData { GameSpeedUp=speedUp, GameDifficultyUp=difficultyUp, GameVarietyUp=varietyUp };
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(jsonSettingsPath, json);
    }

    public void LoadSettings() {
        if (File.Exists(jsonSettingsPath)) {
            string json = File.ReadAllText(jsonSettingsPath);
            SettingsData data = JsonUtility.FromJson<SettingsData>(json);
            GameSpeedUp = data.GameSpeedUp;
            GameDifficultyUp = data.GameDifficultyUp;
            GameVarietyUp = data.GameVarietyUp;
        } else {
            GameSpeedUp = false; 
            GameDifficultyUp = false; 
            GameVarietyUp = false;
        }
    }
}
