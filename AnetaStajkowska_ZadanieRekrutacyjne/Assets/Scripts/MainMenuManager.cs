using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        //change to scene Level1
    }
    public void OnSettingsButtonClick()
    {
        MainMenuWindow.SetActive(false);
        SettingsMenuWindow.SetActive(true);
    }
    public void OnExitButtonClick()
    {
        Application.Quit();
    }
    public void OnReturnButtonClick()
    {
        SettingsMenuWindow.SetActive(false);
        MainMenuWindow.SetActive(true);
    }
}
