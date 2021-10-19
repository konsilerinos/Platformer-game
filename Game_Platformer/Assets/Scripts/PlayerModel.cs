using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel : MonoBehaviour
{
    public bool IsDead = false;
    public float speed;
    public float const_speed;
    protected Animation anim;
    protected Rigidbody2D player;
}

