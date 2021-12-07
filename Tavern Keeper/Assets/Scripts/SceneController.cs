using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("ShawScene");
    }

    public void LoadValeriaGame()
    {
        SceneManager.LoadScene("VampireScene");
    }

    public void LoadQuinnGame()
    {
        SceneManager.LoadScene("QuinnScene");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game");
        Application.Quit();
    }
}
