using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlwaysRotate : MonoBehaviour
{

    public float rotateSpeed=30f;
    void Update()
    {
            transform.RotateAround(transform.position,Vector3.up,rotateSpeed *Time.deltaTime );
    }
}
