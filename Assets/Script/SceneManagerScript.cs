using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    public void LoadMainMenu(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainScene");
    }

    public void LoadGame(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }

    public void QuitGame(){
        Application.Quit();
    }
}
