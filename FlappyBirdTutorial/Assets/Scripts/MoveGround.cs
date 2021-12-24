using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGround : MonoBehaviour
{
    public Rigidbody2D _rigidbody2D;

    public float Speed;
    void FixedUpdate()
    {//Move ground
        _rigidbody2D.velocity = Vector2.zero;
        _rigidbody2D.AddForce(Vector3.left * Speed);

        if(transform.position.x <= -0.67f)
        {
            transform.position = new Vector2 (1.014f, -1);
        }
        if (Score.score > 50)
        {
            Speed = 20;
        }
    }


}
