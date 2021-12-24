using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipes : MonoBehaviour
{
    public Rigidbody2D _rigidbody2D;

    public float Speed;
    void FixedUpdate()
    {//Move pipes
        _rigidbody2D.velocity = Vector2.zero;
        _rigidbody2D.AddForce(Vector3.left * Speed);
        if (Score.score > 50)
        {
            Speed = 20;
        }
    }
}
