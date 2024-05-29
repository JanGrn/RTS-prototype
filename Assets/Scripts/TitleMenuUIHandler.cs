using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class TitleMenuUIHandler : MonoBehaviour {
    // Title canvas elements
    private GameObject TitleCanvas;
    private Button StartButton;
    private Button ExitButton;
    private Button SettingsButton;

    // Settings canvas elements
    private GameObject SettingsCanvas;
    private Button ExitSettingsButton;
    private Toggle GameSpeedUpToggle;
    private Toggle GameDifficultyUpToggle;
    private Toggle GameVarietyUpToggle;

    // Start is called before the first frame update
    void Start() {
        // Load settings from a previous run
        SettingsManager.Instance.LoadSettings();

        initTitleCanvasFunctionality();
        initSettingsCanvasFunctionality();



        // SettingsCanvas.gameObject.SetActive(true);
        // StartCoroutine(TestActivationAndDeactivation());
        // StartButton.onClick.AddListener(testAction);
    }

    private void initTitleCanvasFunctionality() {
        TitleCanvas = GameObject.Find("Title Canvas");
        SettingsCanvas = GameObject.Find("Settings Canvas");

        StartButton = GameObject.Find("Start Button").GetComponent<Button>();
        StartButton.onClick.AddListener(() => {
            SceneManager.LoadScene(1);
        });

        ExitButton = GameObject.Find("Exit Button").GetComponent<Button>();
        ExitButton.onClick.AddListener(() => {
#if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
#else
            Application.Quit();
#endif
        });

        SettingsButton = GameObject.Find("Settings Button").GetComponent<Button>();
        SettingsButton.onClick.AddListener(() => {
            TitleCanvas.SetActive(false);
            SettingsCanvas.SetActive(true);
        });
    }

    private void initSettingsCanvasFunctionality() {
        SettingsCanvas.SetActive(true);
        GameSpeedUpToggle = GameObject.Find("Game Speed Up Toggle").GetComponent<Toggle>();
        GameSpeedUpToggle.isOn = SettingsManager.Instance.GameSpeedUp;

        GameDifficultyUpToggle = GameObject.Find("Game Difficulty Up Toggle").GetComponent<Toggle>();
        GameDifficultyUpToggle.isOn = SettingsManager.Instance.GameDifficultyUp;

        GameVarietyUpToggle = GameObject.Find("Game Variety Up Toggle").GetComponent<Toggle>();
        GameVarietyUpToggle.isOn = SettingsManager.Instance.GameVarietyUp;

        ExitSettingsButton = GameObject.Find("Exit Settings Button").GetComponent<Button>();
        ExitSettingsButton.onClick.AddListener(() => {
            SettingsCanvas.SetActive(false);
            TitleCanvas.SetActive(true);

            // serialize data
            SettingsManager.Instance.SaveSettings(GameSpeedUpToggle.isOn, GameDifficultyUpToggle.isOn, GameVarietyUpToggle.isOn);
        });
        SettingsCanvas.SetActive(false);
    }

    private IEnumerator TestActivationAndDeactivation() {
        yield return new WaitForSeconds(3); SettingsCanvas.gameObject.SetActive(false);
    }

    private void testAction() {
        Debug.Log("Button clicked");
    }

    // Update is called once per frame
    void Update() {

    }
}
