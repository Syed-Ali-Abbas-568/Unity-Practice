using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Unity.VisualScripting.Antlr3.Runtime.Tree;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    private float spawnRate = 1.0f;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameoverText;
    public TextMeshProUGUI livesText;
    private int lives = 0;
    public Button button;

    public GameObject titleScreen;

    public Image pauseScreen;

    public TrailRenderer trail;

    private AudioSource gameOverSound;



    public bool isGameActive = false;
    private float score = 0;

    public bool pause = false;

    void Start()
    {
        gameOverSound = GameObject.Find("Audio Manager").GetComponents<AudioSource>()[2];
    }
    

    void Update()
    {
        if(Input.GetMouseButton(0)  && !pause)
        {
            trail.gameObject.SetActive(true);

        }
        else{
            trail.gameObject.SetActive(false);
        }


        if (Input.GetKeyDown(KeyCode.Space) && isGameActive)
        {

            pause = !pause;

            Time.timeScale = (pause) ? 0 : 1;

            pauseScreen.gameObject.SetActive(pause);
            Debug.Log("GAME PAUSED");
        }
    }


    private void UpdateLivesText()
    {
        livesText.text = "LIVES: " + lives;
    }

    public void DecrementLife()
    {

        if (lives != 0)
        {
            lives -= 1;
        }
        UpdateLivesText();
        if (lives == 0)
        {
            ShowGameOver(true);
        }

    }

    public void StartGame(int difficulty, int lives)
    {
        titleScreen.gameObject.SetActive(false);
        pauseScreen.gameObject.SetActive(pause);
        this.lives = lives;
        isGameActive = true;
        score = 0;
        UpdateScore(0);
        UpdateLivesText();
        StartCoroutine(SpawnTargets());
        spawnRate /= difficulty;

    }
    public void ShowGameOver(bool flag)
    {

        gameoverText.gameObject.SetActive(flag);
        button.gameObject.SetActive(true);

        if (isGameActive)
        { gameOverSound.Play(0); }
        isGameActive = false;
    }

    public void UpdateScore(int scoreToAdd)
    {

        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    IEnumerator SpawnTargets()
    {

        while (isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int choice = Random.Range(0, targets.Count);
            Instantiate(targets[choice]);
        }
    }
}
