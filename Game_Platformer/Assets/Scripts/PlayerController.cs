using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class PlayerController : PlayerModel
{
    private BoxCollider2D box_collider;
    private SpriteRenderer spriterend;
    public Sprite idle;
    public Sprite moving;
    [SerializeField]
    private bool IsGrounded;
    public float Jump_speed;
    private GameObject temp;

    private void Awake()
    {
        player = GetComponent<Rigidbody2D>();
        box_collider = GetComponent<BoxCollider2D>();
        spriterend = GetComponent<SpriteRenderer>();
        const_speed = speed;
    }

    void Update()
    {
        Movement();
    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.LeftShift)) speed = const_speed * 1.5f;
        else speed = const_speed;
        if (Input.GetKey(KeyCode.D) || Input.GetKey("right"))
        {
            player.velocity = new Vector2(speed, player.velocity.y);
            spriterend.flipX = false;
            spriterend.sprite = moving;
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey("left"))
        {
            player.velocity = new Vector2(-speed, player.velocity.y);
            spriterend.flipX = true;
            spriterend.sprite = moving;
        }
        if (IsGrounded)
        {
            if ((Input.GetKey(KeyCode.W) || Input.GetKey("up") || Input.GetKey(KeyCode.Space)) && !spriterend.flipX)
            {
                if (speed == const_speed)
                    player.velocity = new Vector2(2f * speed, Jump_speed);
                else
                    player.velocity = new Vector2(speed, Jump_speed);
                IsGrounded = false;
            }
            else if ((Input.GetKey(KeyCode.W) || Input.GetKey("up") || Input.GetKey(KeyCode.Space)) && spriterend.flipX)
            {
                if (speed == const_speed)
                    player.velocity = new Vector2(-2f * speed, Jump_speed);
                else
                    player.velocity = new Vector2(-speed, Jump_speed);
                IsGrounded = false;
            }
        }
        if(player.velocity.x == 0)
        {
            spriterend.sprite = idle;
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu", LoadSceneMode.Additive);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ContactPoint2D[] contacts = new ContactPoint2D[1];

        collision.GetContacts(contacts);
        var contactPoint = contacts[0].point;
        if (contactPoint.normalized.y <= 0)
            IsGrounded = true;
    }
    
    private void OnCollisionExit2D(Collision2D collision)
    {
        IsGrounded = false;
    }
}