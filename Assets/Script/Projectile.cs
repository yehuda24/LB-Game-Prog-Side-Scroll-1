using System;
using Unity.VisualScripting;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private GameObject player;
    private Rigidbody2D rb2d;
    public float force;
    [SerializeField] private float lifeTime;
   

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
       
        Vector3 direction = player.transform.position - transform.position;
        rb2d.velocity = new Vector2(direction.x, direction.y).normalized * force;

        float rotation = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotation);
    }

    void Update()
    {
        lifeTime -= Time.deltaTime;

        if (lifeTime <= 0f)
        {
            Destroy(gameObject);
        }
    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

}

