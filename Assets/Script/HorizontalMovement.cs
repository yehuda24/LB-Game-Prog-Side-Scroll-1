using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovement : MonoBehaviour
{
    static float t = 0.0f;
    public float distance, speed;
    private float originalPosX;
    bool isRotate = false;

    void Start()
    {
        originalPosX = transform.position.x;   
    }

    void Update()
    {
        transform.position = new Vector3(originalPosX + Mathf.Sin(t) * distance, transform.position.y,transform.position.z);
        t += speed * Time.deltaTime;
    }
}
