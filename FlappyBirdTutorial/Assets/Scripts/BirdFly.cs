using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdFly : MonoBehaviour
{
    public GameManager GameManager;

    public float Power = 1f;
    private bool _isPressedToJump = false;

    private Rigidbody2D _rigidbody2D;

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _isPressedToJump = true;
        }

    }
    void FixedUpdate()
    {
        if (_isPressedToJump)
        {
            MakeJump();
        }
        _isPressedToJump = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.GameOver();
    }

    private void MakeJump()
    {
        _rigidbody2D.velocity = Vector2.zero;
        _rigidbody2D.AddForce(Vector2.up * Power, ForceMode2D.Impulse);
    }
}
