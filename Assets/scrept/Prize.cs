using UnityEngine;

public class Prize : MonoBehaviour
{
    void Update()
    {
        if (transform.position.y < -10) 
        {
            Destroy(gameObject);
        }
    }
}
