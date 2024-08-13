using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    private Button button;
    private GameManager gameManager;
    public int lives=4;
    
    public int difficulty=0;

    void Start()
    {
        button=GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
        gameManager=GameObject.Find("Game Manager").GetComponent<GameManager>();
    }


    void SetDifficulty()
    {
        Debug.Log(button.gameObject.name +" Was clicked");
        gameManager.StartGame(difficulty,lives);
    }
}
