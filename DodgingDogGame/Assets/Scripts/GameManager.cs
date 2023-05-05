using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private bool _gameOver = false;


    void Awake()
    {
        Instance = this;
    }

    
    void Update()
    {
        
    }


    public void GameOver()
    {
        _gameOver = true;

        GameObject.Find("ObstacleSpawner").GetComponent<ObstacleSpawner>().StopSpawning();
    }
}
