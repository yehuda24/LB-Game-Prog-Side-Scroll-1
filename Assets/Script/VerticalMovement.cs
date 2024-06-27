using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovement : MonoBehaviour
{
    static float t = 0.0f;
    public float distance;
    public float speed;
    private float originalPosY;
    bool isRotate = false;

    /*[Header("Flip Position")]
    public float posYLeft;
    public float posYRight;*/
    private SpriteRenderer sprite;

    void Start()
    {
        originalPosY = transform.position.y;
        sprite = GetComponent<SpriteRenderer>();
    }

    /*void SpriteFlip()
    {
        if (transform.localPosition.x < posXLeft)
        {
            sprite.flipX = false;
        }
        else if (transform.localPosition.x > posXRight)
        {
            sprite.flipX = true;
        }
    }*/

    void Update()
    {
        var ms = Mathf.Sin(t) * distance;
        var y = originalPosY + ms;
        transform.position = new Vector3(transform.position.x, y, transform.position.z);
        t += speed * Time.deltaTime;
        /*SpriteFlip();*/
    }

   /* private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.parent = this.transform;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.parent = null;
        }
    }*/
}
