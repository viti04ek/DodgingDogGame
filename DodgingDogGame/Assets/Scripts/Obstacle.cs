using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float RotationSpeed;

    
    void FixedUpdate()
    {
        transform.Rotate(0, 0, RotationSpeed);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            GameManager.Instance.GameOver();
        }
    }
}
