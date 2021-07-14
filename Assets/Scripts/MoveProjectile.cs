using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveProjectile : MonoBehaviour
{
    public Rigidbody2D projectile;
    public float moveSpeed = 30.0f;

    
    void Start()
    {
        projectile = this.gameObject.GetComponent<Rigidbody2D>();
        
    }

    
    void Update()
    {
        projectile.velocity = new Vector2(0, 1) * moveSpeed;
    }

    [System.Obsolete]
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            col.gameObject.SetActive(false);
        }

        if (col.gameObject.tag == "Top")
        {
            Object.Destroy(gameObject);
            
        }
    }
}
