using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovement : MonoBehaviour
{
    static float t = 0.0f;
    public float distance; 
    public float speed;
    private float originalPosX;
    bool isRotate = false;

    [Header("Flip Position")]
    public float posXLeft;
    public float posXRight;
    private SpriteRenderer sprite;

    void Start()
    {
        originalPosX = transform.position.x; 
        sprite = GetComponent<SpriteRenderer>();
    }

    void SpriteFlip()
    {
        if(transform.localPosition.x < posXLeft) 
        {
            sprite.flipX = false;
        } 
        else if(transform.localPosition.x > posXRight)
        {
            sprite.flipX = true;
        }
    }

    void Update()
    {
        var ms = Mathf.Sin(t) * distance;
        var x = originalPosX + ms;
        transform.position = new Vector3(x, transform.position.y,transform.position.z);
        t += speed * Time.deltaTime;
        SpriteFlip();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            collision.transform.parent = this.transform;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            collision.transform.parent = null;
        }
    }
}
