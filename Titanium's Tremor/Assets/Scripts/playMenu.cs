using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playMenu : MonoBehaviour
{
    [SerializeField] private GameObject optionsMenu;
    public void optionsMenuShow() {
        gameObject.SetActive(false);
        optionsMenu.SetActive(true);
    }

    public void launchGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void quitGame() {
        Console.WriteLine("QUITTING !");
        Application.Quit();
    }
}