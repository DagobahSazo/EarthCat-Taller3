using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager manager;


    private void Awake()
    {
        manager = this;
    }

    public void ExitGame()
    {
        Debug.Log("Guaracha");
        Application.Quit();
    }

    public void GoTuto()
    {
        SceneManager.LoadScene(1);
    }

    public void ResetearJuego()
    {
        SceneManager.LoadScene("Menu");
    }

    public void StartGame()
    {
        SceneManager.LoadScene(2);
    }


}
