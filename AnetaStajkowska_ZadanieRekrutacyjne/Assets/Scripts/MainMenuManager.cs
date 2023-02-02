using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject MainMenuWindow;
    public GameObject SettingsMenuWindow;

    public GameObject StartButton;
    public GameObject SettingsButton;
    public GameObject ExitButton;

    public GameObject ReturnButton;
    public GameObject Toggle1;
    public GameObject Toggle2;

    float Selection;

    void Awake()
    {
        SettingsMenuWindow.SetActive(false);
    }

    public void OnStartButtonClick()
    {
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);
    }
    public void OnSettingsButtonClick()
    {
        MainMenuWindow.SetActive(false);
        SettingsMenuWindow.SetActive(true);
    }
    public void OnExitButtonClick()
    {
        Application.Quit();
        Debug.Log("Aplication should quit now.");
    }
    public void OnReturnButtonClick()
    {
        SettingsMenuWindow.SetActive(false);
        MainMenuWindow.SetActive(true);
    }
}
