using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    //Movement
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void DoMove(Vector2 movementValue, float speed)
    {
        float horizontalVelocity = movementValue.normalized.x * speed;
        float verticalVelocity = movementValue.normalized.y * speed;
        _rigidbody.velocity = new Vector2(horizontalVelocity, verticalVelocity);
    }
}
