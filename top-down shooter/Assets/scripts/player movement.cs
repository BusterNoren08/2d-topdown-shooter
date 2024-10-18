using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playermovement : MonoBehaviour

{
    Vector2 moveInput;
    Rigidbody2D rb;
    [SerializeField] float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = moveInput * moveSpeed;
        Debug.Log(moveInput);
    }
}
