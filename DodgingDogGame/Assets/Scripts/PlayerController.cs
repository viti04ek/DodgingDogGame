using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D Rigidbody2D;
    public float Speed;
    public SpriteRenderer SpriteRenderer;

    
    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            if (Input.mousePosition.x < Screen.width / 2)
            {
                Rigidbody2D.velocity = Vector2.left * Speed;
                SpriteRenderer.flipX = true;
            }
            else
            {
                Rigidbody2D.velocity = Vector2.right * Speed;
                SpriteRenderer.flipX = false;
            }
        }
    }
}
