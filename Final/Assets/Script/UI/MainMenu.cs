using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject optionMenuUI;
    public GameObject characterMenuUI;
    public void OnStartButton()
    {
        SceneManager.LoadScene("Lv1");
    }

    public void OptionButton()
    {
        optionMenuUI.SetActive(true);
    }

    public void CharacterButton()
    {
        characterMenuUI.SetActive(true);
    }

    public void OptionBackButton()
    {
        optionMenuUI.SetActive(false);
    }

    public void CharacterBackButton()
    {
        characterMenuUI.SetActive(false);
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
