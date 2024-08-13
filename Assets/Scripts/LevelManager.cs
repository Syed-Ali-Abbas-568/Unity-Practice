using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;




public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject score;
    public GameObject lives;
    public GameObject gameOver;
    public GameObject restart;

    private TMP_Text scoreText;
    private TMP_Text livesText;

    public GameObject player;

    int scoreVar = 0;
    int liveVar = 5;



    void InitialState()
    {
        gameOver.SetActive(false);
        restart.SetActive(false);
        scoreText = score.GetComponent<TMP_Text>();
        livesText = lives.GetComponent<TMP_Text>();
        scoreText.text = "Score: 0";
        livesText.text = "Lives: 5";
        scoreVar = 0;
        liveVar = 5;
    }

    void Start()
    {
        InitialState();
    }



    public void IncrementScore()
    {
        scoreVar += 1;
        scoreText.text = $"Score: {scoreVar}";

    }

    public void DecrementLife()
    {
        liveVar -= 1;
        livesText.text = $"Lives: {liveVar}";
        if (liveVar == 0)
        {
            ShowGameOver();
        }
        else
        {
            Instantiate(player, Vector3.zero, player.transform.rotation);
        }
    }

    void ShowGameOver()
    {
        gameOver.SetActive(true);
        restart.SetActive(true);
    }


    public void RestartGame()
    {

        SceneManager.LoadSceneAsync("Prototype 2");
    }
    // Update is called once per frame
}
