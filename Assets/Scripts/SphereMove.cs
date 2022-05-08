using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SphereMove : MonoBehaviour
{
    private Rigidbody rigidbody;
    private float moveX;
    private float moveZ;
    public float _speed;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 move = new Vector3(moveX, 0.0f, moveZ);

        rigidbody.AddForce(move * _speed);
    }

    void OnMove(InputValue moveValue)
    {
        Vector2 moveVector = moveValue.Get<Vector2>();
        moveX = moveVector.x;
        moveZ = moveVector.y;
    }
}
