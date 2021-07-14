using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public Rigidbody2D enemyProjectile;
    public float movespeed = 30.0f;
    

    void Start()
    {
        enemyProjectile = this.gameObject.GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        enemyProjectile.velocity = new Vector2(0, -1) * movespeed;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.gameObject.SetActive(false);
        }

        if (col.gameObject.tag == "Bottom")
        {
            Object.Destroy(gameObject);
        }
    }
}
