using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour
{
    //Movement
    public float speed = 1f;
    public ObjectMover objectMover;

    private Rigidbody2D _rigidbody;
    private Vector2 _movement;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        _movement = new Vector2(0, -1);
    }

    private void FixedUpdate()
    {
        objectMover.DoMove(_movement, speed);
    }
}
