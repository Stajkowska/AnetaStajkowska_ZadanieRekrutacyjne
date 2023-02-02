using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1UI : MonoBehaviour
{
    public GameObject ReturnButton;

    public void OnReturnButtonClick()
    {
        SceneManager.LoadScene("MainMenuScene", LoadSceneMode.Single);
    }
}
