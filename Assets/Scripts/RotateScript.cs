using UnityEngine;

public class RotateScript : MonoBehaviour
{

      public float rotationSpeed = 0.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      

        
    }

    // Update is called once per frame
    void Update()
    {
         transform.Rotate(0, rotationSpeed, 0);
    }
}
