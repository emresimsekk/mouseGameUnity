using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene("Start");
    }
    public void multiplayer()
    {
        SceneManager.LoadScene("Multiplayer");
    }
    public void AI()
    {
        SceneManager.LoadScene("AI");
    }
    public void mainMenu()
    {
        SceneManager.LoadScene("Play");
    }
    public void exit()
    {
        Application.Quit();
    }
}
