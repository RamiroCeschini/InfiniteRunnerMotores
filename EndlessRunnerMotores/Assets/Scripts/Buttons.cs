using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void Play()
    {
        SoundManager.Instance.SwapMusic(false);
        Debug.Log("swap music");
        SceneManager.LoadScene("Game");

    }

    public void PlayAgain()
    {
        SoundManager.Instance.LoseMusic(true);
        SceneManager.LoadScene("Game");

    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Menu()
    {
        SoundManager.Instance.SwapMusic(true);
        SceneManager.LoadScene("Menu");

    }
}
