using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameOverManager : MonoBehaviour
{
    public int maxLives;
    public GameObject gameOverScreen;

    int lives;
    bool gameOver;
    bool restartEnabled;
    Text livesText;

    void Start()
    {
        gameOver = false;
        restartEnabled = false;
        livesText = GameObject.Find("LivesText").GetComponent<Text>();
        lives = maxLives;
        livesText.text = "Lives: " + lives;
    }

    public void LoseLife()
    {
        lives--;
        if (lives <= 0)
        {
            gameOver = true;
        }
        livesText.text = "Lives: " + lives;
    }

    void Update()
    {
        if (gameOver)
        {
            restartEnabled = true;
            gameOverScreen.SetActive(true);
            GameObject waveAmount = GameObject.Find("WavesSurvivedAmount");
            waveAmount.GetComponent<Text>().text = GetComponent<SpawnManager>().GetWave().ToString();
            Time.timeScale = 0;
        }
        if (restartEnabled && Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene("GameScene");
        }
    }

    public void TimedOut()
    {
        gameOver = true;
    }

	public bool GameOver
	{
		get { return gameOver; }
	}
}