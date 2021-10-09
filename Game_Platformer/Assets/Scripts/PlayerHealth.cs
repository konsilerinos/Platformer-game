using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : PlayerModel
{
    private BoxCollider2D enemy;
    private new BoxCollider2D player;

    void Start()
    {
        enemy = GameObject.Find("Enemy").GetComponent<BoxCollider2D>();
        player = GameObject.Find("Player").GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player.IsTouching(enemy))
        {
            IsDead = true;
            /*
             * HERE GOES DEATH MENU
             */
        }
    }
}
