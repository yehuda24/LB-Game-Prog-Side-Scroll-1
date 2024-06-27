using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootProjectile : MonoBehaviour
{
    public GameObject projectile;
    public Transform projectilePos;
    private float timer;
    private GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        
        float distance = Vector2.Distance(transform.position, player.transform.position);
        Debug.Log(distance);

        if(distance < 4)
        {
            timer += Time.deltaTime;

            if(timer > 2)
            {
                timer = 0;
                Shoot();
            }
        }

        
    }

    void Shoot()
    {
        Instantiate(projectile, projectilePos.position, Quaternion.identity);
    }
}
