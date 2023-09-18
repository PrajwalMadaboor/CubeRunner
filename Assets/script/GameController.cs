using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject gameEndPanel;
    public GameObject taptostart;
    public GameObject scoreText;
    public GameObject creatorpanel;

    private void Start()
    {
        gameOverPanel.SetActive(false);
        gameEndPanel.SetActive(false);
        taptostart.SetActive(true);
        scoreText.SetActive(false);
        creatorpanel.SetActive(false);
         PauseGame();
      
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartGame();
        }
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        scoreText.SetActive(false);
        creatorpanel.SetActive(false);
    }
    public void GameOver1()
    {
        gameEndPanel.SetActive(true);
        scoreText?.SetActive(false);
        creatorpanel?.SetActive(false);
    }
   public void GameCredit()
    {
        creatorpanel.SetActive(true);
        scoreText.SetActive(false);
        gameEndPanel.SetActive(false) ;
        gameOverPanel.SetActive(false );
    }
   public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void PauseGame()
    {
        Time.timeScale = 0f;
    }
    public void StartGame()
    {
        taptostart.SetActive(false);
        Time.timeScale = 1f;
        scoreText.SetActive(true);
        

        
    }
}
