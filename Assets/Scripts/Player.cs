using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D player;
    public float moveSpeed = 20.0f;


    public void MovePlayer()
    {

        player.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * moveSpeed;
        
    }


    void Start()
    {
        player = this.GetComponent<Rigidbody2D>();
    }

   
    void FixedUpdate()
    {
        MovePlayer();
    }

    
}
