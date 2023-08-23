using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public Button playButton;
    public Button exitButton;
    

    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    public void CreditButton()
    {
        SceneManager.LoadScene("CreditScene");
    }
}
