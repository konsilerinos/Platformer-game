using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody2D enemy;
    public float speed = 15f;
    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        float distance = GameObject.Find("Player").transform.position.x - GetComponent<Transform>().position.x;

        if (Math.Abs(distance) < 5f)
        {
            if(distance > 0)
            {
                enemy.velocity = new Vector2(speed, enemy.velocity.y);
            }
            else
            {
                enemy.velocity = new Vector2(-speed, enemy.velocity.y);
            }
        }
    }
}
