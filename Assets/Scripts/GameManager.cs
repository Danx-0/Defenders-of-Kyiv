using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;
public class GameManager : MonoBehaviour
{

    int score = 0;
    bool GameOver = false;
    public static GameManager instance;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI gameOverText;
    [SerializeField] GameObject gameOverPanel;

    public Button MenuButton;
    public Button rebootButton;

    private bool gameOverAsset = false; //para que el panel se mantenga desactivado mientras el juego este corriendo
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy (gameObject);
        }
        //instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //void Start()
    //{
    //    if (gameOverPanel != null)  //"AddListener" es para 
    //    {
    //        gameOverPanel.SetActive(false);
    //    }
    //    if (MenuButton != null)
    //    {
    //        MenuButton.onClick.AddListener(GoToMenu);
    //    }
    //    if (rebootButton != null)
    //    {
    //        rebootButton.onClick.AddListener(rebootEcene);
    //    }

    //}
    public void IncreaseScore(int amount)
    {
        score += amount;
        scoreText.text = "Score:" + score;
    }

    // Update is called once per frame
    //    void Update()
    //    {
    //        if (gameOverPanel == true)
    //        {
    //            if (Input.GetKey(KeyCode.R))
    //            {
    //                rebootEcene();
    //            }
    //            if (Input.GetKey(KeyCode.KeypadEnter))
    //            {
    //                GoToMenu();
    //            }
    //        }
    //    }

    ////    public void GameOver()

    ////    {
    ////        if (gameOverPanel == true)  
    //        {

    //        } 
    //    }
}
