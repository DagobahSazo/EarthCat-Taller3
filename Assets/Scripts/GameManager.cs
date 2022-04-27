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

    public void GameOver()
    {

    }

    public void ExitGame()
    {
        
    }

    public void ResetearJuego()
    {
        SceneManager.LoadScene("Menu");
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }


}
