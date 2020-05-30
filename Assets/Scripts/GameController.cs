using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : Singleton<GameController>
{
    [SerializeField] private Text pointsTxt;
    private int points = 0;

    void Start()
    {
        Time.timeScale = 1;
    }

    public void AddPoints()
    {
        points++;
        pointsTxt.text = points.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
