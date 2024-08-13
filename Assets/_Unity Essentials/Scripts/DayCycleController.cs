// 2024-07-22 AI-Tag 
// This was created with assistance from Muse, a Unity Artificial Intelligence product

using UnityEngine;

public class DayCycleController : MonoBehaviour
{
    [Tooltip("Duration of one full day cycle in seconds.")]
    public float dayDuration = 86400f; // Default to 24 hours

    private float rotationSpeed;

    void Start()
    {
        // Calculate the rotation speed based on the duration of the day
        rotationSpeed = 360f / dayDuration;
    }

    void Update()
    {
        // Rotate the light around the y-axis at a constant speed
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
    }
}
