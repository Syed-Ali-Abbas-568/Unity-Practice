

using UnityEngine;

public class OrbitingScript : MonoBehaviour
{
    public GameObject originObject; //reference to the origin objecet
    public float orbitRadius = 5.0f;
    public float orbitSpeed = 1.0f;  

    public float yOffset=2f;

public bool rotateY=true;


 


    private void Update()
    {
        OrbitAround();
        
    }

    
    void OrbitAround()
    {
        //The orbit has been made using a simple cicile equation
        if (originObject != null)
        {
            // Time.time gives the time in seconds since the start of the game
            float x = Mathf.Cos(Time.time * orbitSpeed) * orbitRadius;
            float z = Mathf.Sin(Time.time * orbitSpeed) * orbitRadius;

            //Assigning new position while keeping old y postiiotn since the the orbit is only in the x and y axis for now
            Vector3 newPosition = rotateY ? new Vector3(x,yOffset,z ) : new Vector3(x,z, yOffset);

           
            transform.position = originObject.transform.position + newPosition;
        }
    }
}
