using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCameraScript : MonoBehaviour
{
    public float rotateSpeed=5.0f;


    // Update is called once per frame
    void Update()
    {
        float horizontalInput=Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontalInput*rotateSpeed*Time.deltaTime);
    }
}
