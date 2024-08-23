using System.Collections;
using UnityEngine;

public class satl : MonoBehaviour
{
    public float speed = 10f; 

    void Update()
    {
        float move = Input.GetAxis("Horizontal") * speed * Time.deltaTime; 
        transform.Translate(move, 0, 0);
    }
}
