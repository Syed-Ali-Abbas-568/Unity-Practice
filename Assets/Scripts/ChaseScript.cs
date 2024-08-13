using System.Collections;
using System.Collections.Generic;
using JetBrains.Rider.Unity.Editor;
using TMPro;
using UnityEngine;

public class ChaseScript : MonoBehaviour
{

    private GameObject player;
    public float speed=500f;


    private Rigidbody _selfRb;



    // Start is called before the first frame update
    void Start()
    {
        _selfRb=GetComponent<Rigidbody>();
        player=GameObject.Find("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 lookDirection=(player.transform.position-transform.position).normalized;
        _selfRb.AddForce(speed  * lookDirection);

        if(transform.position.y < -10)
        {
            Destroy(gameObject);
        }

    }
}
