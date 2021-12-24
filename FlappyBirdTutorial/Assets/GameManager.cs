using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject GameOverCanvas;
    public GameObject MainMenuCanvas;

    private void Start()
    {
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        GameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
