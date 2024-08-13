using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
   
   public float upperBound=35f;
   public float lowerBound=-2f;

    // Update is called once per frame
    void Update()
    {
        
        if(transform.position.z > upperBound)
        {
             Destroy(gameObject);
        }
        if(transform.position.x > 28)
        {
             Destroy(gameObject);
        }
        else if(transform.position.x < -38)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over !!"); //Trigger game over
            Destroy(gameObject);
        }
        
    }
}
