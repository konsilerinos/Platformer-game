using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Control : MonoBehaviour
{


    public float speed;
    private Rigidbody2D player;
    private BoxCollider2D box_collider;
    private SpriteRenderer spriterend;
    private bool IsGrounded = true;
    public float Jump_speed;
    private GameObject ground;
    

  
    void Start()
    {

        player = GetComponent<Rigidbody2D>();
        box_collider = GetComponent<BoxCollider2D>();
        spriterend = GetComponent<SpriteRenderer>();
        ground = GameObject.Find("Square");
    }

    void Update()
    {




        if (Input.GetKey(KeyCode.D) || Input.GetKey("right"))
        {
            player.velocity = new Vector2(speed, player.velocity.y);
            spriterend.flipX = false;

        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey("left"))
        {
            player.velocity = new Vector2(-speed, player.velocity.y);
            spriterend.flipX = true;
        }
        if ((Input.GetKey(KeyCode.W) || Input.GetKey("up") || Input.GetKey(KeyCode.Space)) && IsGrounded )
        {
            player.velocity = new Vector2(player.velocity.x, Jump_speed);
            IsGrounded = false;

        }
        if(box_collider.IsTouching(ground.GetComponent<BoxCollider2D>()))
        {
            IsGrounded = true;
        }
    }
    
}
