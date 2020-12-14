﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void optionMenu()
    {
        SceneManager.LoadScene("Options Menu");
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
