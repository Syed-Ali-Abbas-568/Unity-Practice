using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEditor;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public Vector3 scaleLimit = 10.0f * Vector3.one;
    private Material material;
    private float randomColor;
    bool grow = true;
    bool reverse = true;

    Color start = new Color(252, 186, 3);
    Color end = new Color(224, 11, 185);

    float currentQuantity = 0f;
    float desiredQuantity = 210f;
    public float colorSpeed = 20f;

    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;

        material = Renderer.material;

        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);

        randomColor = Random.Range(1.0f, 100f);

    }


    void ChangeColor()
    {

       
        if (currentQuantity <4.0f && !reverse)
        {
            currentQuantity = Mathf.MoveTowards(currentQuantity, desiredQuantity, Time.deltaTime * colorSpeed);

        }
        else if(currentQuantity > 1f )
        {
            currentQuantity=Mathf.Lerp(currentQuantity, 0.5f, Time.deltaTime * colorSpeed);
            reverse=true;
        }
        else
        {
            reverse=false;
        }

        material.color = new Color(currentQuantity, 1.0f, 0.3f, 0.4f);

         Debug.Log($"{currentQuantity}, {desiredQuantity}");

    }
    void Update()
    {
        transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);

        ChangeColor();



        if (transform.localScale.x < scaleLimit.x && grow)
        {
            transform.localScale += 0.5f * Time.deltaTime * Vector3.one;

        }
        else if (transform.localScale.x > Vector3.one.x)
        {
            grow = false;

            transform.localScale -= Vector3.one * Time.deltaTime;

        }
        else
        {
            grow = true;
        }
    }
}
