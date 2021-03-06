using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D enemy;
    public float moveSpeed = 20.0f;
    //public bool changeDirection = false; //  FOR THE AI (Movement)

    // For 2 player
    public void MovePlayer()
    {

        enemy.velocity = new Vector2(Input.GetAxis("Horizontal2"), Input.GetAxis("Vertical2")) * moveSpeed;
        
    }

    void Start()
    {
        //enemy = this.gameObject.GetComponent<Rigidbody2D>(); // FOR AI
        enemy = this.GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        MovePlayer(); //for second player

        //moveEnemy(); // FOR AI
    }

    // FOR AI (Movement)

    /*
    public void moveEnemy()
    {
        if (changeDirection == true)
        {
            enemy.velocity = new Vector2(1, 0) * -1 * moveSpeed;
        }
        else if (changeDirection == false)
        {
            enemy.velocity = new Vector2(1, 0) * moveSpeed;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "RightWall")
        {
            Debug.Log("Hit the right wall!");
            changeDirection = true;
        }

        if (collision.gameObject.name == "LeftWall")
        {
            Debug.Log("Hit the left wall!");
            changeDirection = false;
        }
    }


    */



}
