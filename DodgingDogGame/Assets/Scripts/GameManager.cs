using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private bool _gameOver = false;

    private int _score = 0;
    public Text ScoreText;

    public GameObject GameOverPanel;


    void Awake()
    {
        Instance = this;
    }


    public void GameOver()
    {
        _gameOver = true;

        GameObject.Find("ObstacleSpawner").GetComponent<ObstacleSpawner>().StopSpawning();

        GameOverPanel.SetActive(true);
    }


    public void IncrementScore()
    {
        if (!_gameOver)
        {
            _score++;
            ScoreText.text = _score.ToString();
        }
    }


    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }


    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
