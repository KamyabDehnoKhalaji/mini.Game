using UnityEngine;

public class lol : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // بررسی برخورد با شیء با تگ "water"
        Debug.Log("Collision detected with: " + collision.gameObject.name);
        if (collision.gameObject.CompareTag("water"))
        {
            // نابود کردن شیء برخوردی
            Destroy(collision.gameObject);
        }
    }
}
