using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 25f;
    private PlayerController playerController;


    private void Start()
    {

        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

        if(!playerController.gameOver){
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        }


    }
}
