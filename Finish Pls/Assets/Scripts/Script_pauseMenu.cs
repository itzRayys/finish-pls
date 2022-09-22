using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script_pauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject gameOverlay;
    public static bool isPaused = false;
    public static bool peekingGame = false;
    public Button zoomInButton;
    public Button zoomOutButton;



    void Update()
    {
        if (Input.GetButtonDown("pause"))
        {
            if (!isPaused)
            {
                pauseGame();
            }
            else
            {
                unpauseGame();
            }
        }

        if (peekingGame)
        {
            if (Input.anyKeyDown)
            {
                unpeekGame();
            }
        }
    }

    public void pauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        zoomInButton.interactable = false;
        zoomOutButton.interactable = false;
    }

    public void unpauseGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        zoomInButton.interactable = true;
        zoomOutButton.interactable = true;
    }

    public void quitGame()
    {
        // saveGame();
        Debug.Log("closing game, have a nice day!! :D");
        Application.Quit();
    }

    public void peekGame()
    {
        peekingGame = true;
        pauseMenu.SetActive(false);
    }

    public void unpeekGame()
    {
        peekingGame = false;
        pauseMenu.SetActive(true);
    }
}
