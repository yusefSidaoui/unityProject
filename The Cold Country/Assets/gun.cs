using System.Security.Cryptography;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Rendering;
using UnityEditor;

public class gun : MonoBehaviour
{
    public Camera cam;
    public Rigidbody2D rb;

    public Transform firePoint;
    
    Vector2 movement;
    Vector2 mousePos;

    // Update is called once per frame
    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate()
    {
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
    }
}
