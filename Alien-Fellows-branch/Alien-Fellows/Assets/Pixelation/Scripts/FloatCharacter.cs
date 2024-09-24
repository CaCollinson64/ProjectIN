using UnityEngine;

public class FloatCharacter : MonoBehaviour
{
    
   [SerializeField] public float height = 1f; 
   [SerializeField] public float speed = 0.5f;  
    private Vector3 originalPosition;

    private void Start()
    {
        // Store the original position of the character
        originalPosition = transform.position;
    }

    private void Update()
    {
        // Calculate the new vertical position using sine wave
        float newY = originalPosition.y + height * Mathf.Sin(Time.time * speed);

        // Update the character's position
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}