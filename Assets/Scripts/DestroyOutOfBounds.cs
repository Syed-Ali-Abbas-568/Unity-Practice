using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    public float leftBound=-10.0f;
    public float rightBound=0;
    public float upperBound=0;
    public float lowerBound=0;

    
    void Update()
    {
        if(transform.position.x < leftBound){
            Destroy(gameObject);

        }
        
    }
}
