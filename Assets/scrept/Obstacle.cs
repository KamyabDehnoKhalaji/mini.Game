using UnityEngine;

public class Obstacle : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Prize"))
        {
            Destroy(other.gameObject);
        }
    }
}
