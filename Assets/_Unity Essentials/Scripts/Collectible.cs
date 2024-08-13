using UnityEngine;



public class Collectible : MonoBehaviour
{


    public float rotateSpeed=0.5f;
    public GameObject onCollectEffect;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(0,0,rotateSpeed);
        
    }
    private void OnTriggerEnter(Collider other) {

        if(other.CompareTag("Player"))
        {
        // Destroy the collictable, update the score and show an effect
        Destroy(gameObject);

        //Particle effect instationtion
        Instantiate(onCollectEffect, transform.position, transform.rotation);
        }
        

}
    
}
