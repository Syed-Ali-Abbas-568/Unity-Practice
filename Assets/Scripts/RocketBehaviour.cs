using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting.APIUpdating;

public class RocketBehaviour : MonoBehaviour
{
    public float fireSpeed = 10.0f;
    public float impact = 500.0f;

    public float aliveTime = 5.0f;

    private bool homing = false;

    public GameObject targetToHit = null;

    public void FireMissle(GameObject target)
    {

        targetToHit = target;
        homing = true;
        Destroy(gameObject, aliveTime);



    }


    private void OnCollisionEnter(Collision col)
    {
        if (targetToHit != null)
        {
            if (col.gameObject.CompareTag(targetToHit.tag))
            {
                Rigidbody targetRigidbody = col.gameObject.GetComponent<Rigidbody>();
                Vector3 away = -col.contacts[0].normal;
                targetRigidbody.AddForce(away * impact, ForceMode.Impulse);
                Destroy(gameObject);
            }
        }


    }



    void Update()
    {
        if (homing && targetToHit != null)
        {
            Vector3 moveDirection = (targetToHit.transform.position -
            transform.position).normalized;
            transform.position += moveDirection * fireSpeed * Time.deltaTime;

            //transform.rotation = Quaternion.FromToRotation(transform.position,new Vector3(0, 0, 1));
           transform.LookAt(targetToHit.transform, moveDirection);
           //Debug.DrawLine(Vector3.zero,new Vector3(0,8,8));
        }
        else if(homing){
            Destroy(gameObject);
        }
    }
}
