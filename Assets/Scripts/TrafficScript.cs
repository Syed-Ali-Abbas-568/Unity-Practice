using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TrafficScript : MonoBehaviour
{
    // Start is called before the first frame update 
    public float trafficSpeed=10f;

    // Update is called once per frame
    void Update()
    {

        transform.Translate(trafficSpeed*Vector3.forward * Time.deltaTime);
        
    }
}
