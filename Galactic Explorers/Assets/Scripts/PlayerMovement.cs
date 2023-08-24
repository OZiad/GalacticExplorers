using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{

    private Vector2 moveInput;
    private Rigidbody2D playerRigidbody2D;
    [SerializeField] private float moveSpeed = 5f;
    void Start()
    {
        playerRigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Run();
    }
    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
        Debug.Log(moveInput);
    }

    void OnFire()
    {

    }
    void Run()
    {
        playerRigidbody2D.velocity = moveInput * moveSpeed;
    }
}
