using UnityEngine;

public class DestroyOnTouch : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            Destroy(other.gameObject);
        }
    }
}
