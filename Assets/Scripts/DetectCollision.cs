using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class DetectCollision : MonoBehaviour
{

    private LevelManager targetScript;
    private Slider slider;

    public float health = 2f;

    // Start is called before the first frame update
    void Start()
    {

        targetScript = FindObjectOfType<LevelManager>();


    }

    public void UpdateHealth(GameObject other)
    {

        slider.value += 1f / health;
        Debug.Log($"slider Value:{slider.value} ");
        if (slider.value == 1.0f)
        {
            targetScript.IncrementScore();
            Destroy(other);
        }

        Destroy(gameObject);
    }




    private void OnTriggerEnter(Collider other)
    {

        if (gameObject.tag == "Projectile" && other.tag != "Player")
        {

            slider = other.GetComponentInChildren<Slider>();
            Debug.Log("Increase Score");
            UpdateHealth(other.gameObject);


        }

        if (other.tag != "Player" || gameObject.tag != "Projectile")
        {


            // Destroy(other.gameObject);

            if (other.tag == "Player")
            {
                Debug.Log("Game Over");
                targetScript.DecrementLife();
                Destroy(other.gameObject);
                Destroy(gameObject);

            }



        }




    }
}
