﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour {

    public void PlayGame()
    {
        SceneManager.LoadScene("Poziom1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void NewGame()
    {
        SceneManager.LoadScene("newGame");
    }
}
