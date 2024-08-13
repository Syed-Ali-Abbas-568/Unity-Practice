using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Il2Cpp;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    // Update is called once per frame

    public float coolDown = 3.0f;
    private float elapsedTime=0.0f;
    private bool allowSpace=true;


    void Update()
    {



        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && allowSpace)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            allowSpace=false;
        }
        else
        {
                    elapsedTime += Time.deltaTime;

                    if(elapsedTime>= coolDown){
                        allowSpace=true;
                        elapsedTime=0;
                    }

        }
    }
}
