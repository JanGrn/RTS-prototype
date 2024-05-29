using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class TitleMenuUIHandler : MonoBehaviour
{
    private Canvas SettingsCanvas;
    private Button StartButton;
    private Button ExitButton;
    private Button SettingsButton;

    // Start is called before the first frame update
    void Start()
    {
        SettingsCanvas = GameObject.Find("Settings Canvas").GetComponent<Canvas>();
        StartButton = GameObject.Find("Start Button").GetComponent<Button>();
        ExitButton = GameObject.Find("Exit Button").GetComponent<Button>();
        SettingsButton = GameObject.Find("Settings Button").GetComponent<Button>();

        SettingsCanvas.gameObject.SetActive(true);
        StartCoroutine(TestActivationAndDeactivation());
        

        // StartButton.onClick.AddListener(testAction);
    }

    private IEnumerator TestActivationAndDeactivation() {
        yield return new WaitForSeconds(3); SettingsCanvas.gameObject.SetActive(false);
    }

    private void testAction() {
        Debug.Log("Button clickd");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
