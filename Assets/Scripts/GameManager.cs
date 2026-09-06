using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public int highScore = 0;
    public int score = 0;
    //bool GameOver = false;
    public static GameManager instance;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI lifesText;
    [SerializeField] GameObject gameOverPanel;
    [SerializeField] TextMeshProUGUI highScoreText;
    [SerializeField] AudioSource AudSource;//pa cuando el juego esta corriendo
    [SerializeField] AudioSource efecSondSource;//pa los botones        
    [SerializeField] AudioClip gameOverSound;
    [SerializeField] AudioClip buttonClickSound;



    // public Button MenuButton;
    //public Button rebootButton;

    //    private bool gameOverAsset = false; //para que el panel se mantenga desactivado mientras el juego este corriendo
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        //instance = this;
    }

    //Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreText.text = "HighScore:" + highScore;

    }
    public void IncreaseScore(int amount)
    {
        score += amount;
        scoreText.text = "Score:" + score;
    }

    public void UpdateLifes(int curretnlifes)
    {
        lifesText.text = "lifes: " + curretnlifes;
    }

    public void OpenGameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0;

        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
            highScoreText.text = "HighScore: " + highScore;
            //score = HighScore;
            //PlayerPrefs.SetInt("HighScore", HighScore);
            //PlayerPrefs.Save();
            //if (highScoreText != null)
            //{
            //    highScoreText.text = "Best: " + HighScore;
            //}
        }
        if (AudSource != null)
        {
            AudSource.Pause();
        }
        if (efecSondSource != null && gameOverSound != null)
        {
            efecSondSource.PlayOneShot(gameOverSound);
        }
    }

    public void PlayButtonSound()
    {
        if (efecSondSource != null && buttonClickSound != null)
        {
            efecSondSource.PlayOneShot(buttonClickSound);
        }
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
