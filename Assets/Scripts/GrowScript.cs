using UnityEngine;

public class GrowScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(CoRoutines.GrowAndAppear.GrowAndAppearRoutine(gameObject));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
