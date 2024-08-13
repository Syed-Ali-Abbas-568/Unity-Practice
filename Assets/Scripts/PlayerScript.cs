using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public float speed = 800.0f;
    public float powerUpStrength = 10.0f;
    public bool hasPowerUp = false;


    public GameObject PowerUpIndicator;

    public GameObject RocketPrefab;

    private PowerType powerType = PowerType.None;
    private Coroutine curruntCoroutine = null;


    private float spamCoolDown = 0.3f;



    private Rigidbody _playerRb;
    private GameObject focalPoint;

    private float currentTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        _playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
        PowerUpIndicator.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float forwardInput = Input.GetAxis("Vertical");
        _playerRb.AddForce(forwardInput * speed * focalPoint.transform.forward);

        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = new Vector3(0, 2, 0);
        }
        PowerUpIndicator.transform.position = transform.position;




    }

    void Update()
    {

        currentTime += Time.deltaTime;
        if (Input.GetKey(KeyCode.Space) && currentTime >= spamCoolDown)
        {
            FireMissle();

            currentTime = 0;

        }

    }

    private void OnTriggerEnter(Collider other)
    {

        if (curruntCoroutine != null)
        {

            StopCoroutine(curruntCoroutine);
            curruntCoroutine = null;
        }
        else
        {
            if (other.CompareTag("PowerUp"))
            {


                hasPowerUp = true;
                Destroy(other.gameObject);


                curruntCoroutine = StartCoroutine(PowerUpCountDownRoutine());
                PowerUpIndicator.SetActive(true);
                powerType = other.gameObject.GetComponent<PowerIconType>().power;


            }

        }
    }

    private void FireMissle()
    {
        if (powerType == PowerType.Rocket)
        {
            foreach (var enemy in GameObject.FindGameObjectsWithTag("Enemy"))
            {
                GameObject temp = Instantiate(RocketPrefab, transform.position + Vector3.up, RocketPrefab.transform.rotation);
                Physics.IgnoreCollision(temp.GetComponent<Collider>(), GetComponent<Collider>());
                temp.GetComponent<RocketBehaviour>().FireMissle(enemy);

            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy") && hasPowerUp && powerType == PowerType.Knockback)
        {
            Rigidbody enemyRb = other.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = other.gameObject.transform.position - transform.position;
            enemyRb.AddForce(powerUpStrength * awayFromPlayer, ForceMode.Impulse);
        }


    }



    IEnumerator PowerUpCountDownRoutine()
    {

        yield return new WaitForSeconds(7);
        hasPowerUp = false;
        powerType = PowerType.None;
        PowerUpIndicator.SetActive(false);
    }


}
