using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Movement
    public float speed = 2.5f;
    public ObjectMover objectMover;

    private Rigidbody2D _rigidbody;
    private Vector2 _movement;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update es el mejor momento para capturar entradas de teclas.
    void Update()
    {
        //--- Movement ---
        float horizontalInput = Input.GetAxisRaw("Horizontal"); //Devuelve el valor del movimiento horizonal final -1 o 1
        float verticalInput   = Input.GetAxisRaw("Vertical"); //Devuelve el valor del movimiento vertical final -1 o 1
        _movement = new Vector2(horizontalInput, verticalInput);
        //--- End ---
    }

    // FixedUpdate es el mejor momento para mover el rigidbody
    private void FixedUpdate()
    {
        objectMover.DoMove(_movement, speed);
    }
}
