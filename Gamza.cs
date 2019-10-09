using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamza : MonoBehaviour
{
    Rigidbody2D rigid2d;
    public float jump = 1500.0f;
    
    void Start()
    {
        this.rigid2d = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "LINE")
        {
            this.rigid2d.AddForce(transform.up * this.jump);
        }
    }
}