using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LearningScene()
    {
        SceneManager.LoadScene("LearningScene");
    }

    public void GameScene() 
    {
        SceneManager.LoadScene("Game");
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}
