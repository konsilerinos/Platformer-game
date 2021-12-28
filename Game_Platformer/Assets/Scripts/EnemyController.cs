using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody2D enemy;
    private SpriteRenderer spriterend;
    public float speed = 15f;
    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<Rigidbody2D>();
        spriterend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = GameObject.Find("Player").transform.position.x - GetComponent<Transform>().position.x;

        if (Math.Abs(distance) < 200f && Math.Abs(distance) > 50f)
        {
            if(distance > 0)
            {
                enemy.velocity = new Vector2(speed, enemy.velocity.y);
                spriterend.flipX = false;
            }
            else
            {
                enemy.velocity = new Vector2(-speed, enemy.velocity.y);
                spriterend.flipX = true;
            }
        }
    }
}
