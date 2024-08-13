using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRb;
    public float xRange = 4.0f;
    float minForce = 12.0f;
    float maxForce = 16.0f;
    public float torqueRange = 10.0f;

    public float yPos = -2;

    private GameManager gameManager;

    private AudioSource badVfx;
    private AudioSource goodVfx;

    public ParticleSystem effect;


    public int pointValue = 5;





    void Start()
    {

        targetRb = GetComponent<Rigidbody>();
        transform.position = RandomSpawnPos();
        targetRb.AddForce(RandomForce(), ForceMode.Impulse);
        targetRb.AddTorque(RandomTorque());
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        AudioSource[] audioList = GameObject.Find("Audio Manager").GetComponents<AudioSource>();
        badVfx = audioList[1];
        goodVfx = audioList[0];



    }

    // Update is called once per frame
    void Update()
    {



    }





    void OnMouseOver()
    {

        if (Input.GetMouseButton(0))
        {
            if (gameManager.isGameActive && !gameManager.pause)
            {
                if (gameObject.CompareTag("Bad"))
                {
                    badVfx.Play(0);
                }
                else
                {
                    goodVfx.Play(0);
                }

                gameManager.UpdateScore(pointValue);
                Instantiate(effect, transform.position, transform.rotation);

                Destroy(gameObject);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {

        if (!gameObject.CompareTag("Bad"))
        {
            gameManager.DecrementLife();
            Destroy(gameObject);
        }
    }


    private Vector3 RandomForce()
    {
        return Random.Range(minForce, maxForce) * Vector3.up;
    }

    private Vector3 RandomTorque()
    {
        return new Vector3(Random.Range(-torqueRange, torqueRange), Random.Range(-torqueRange, torqueRange), Random.Range(-torqueRange, torqueRange));
    }

    private Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-xRange, xRange), yPos);
    }
}
