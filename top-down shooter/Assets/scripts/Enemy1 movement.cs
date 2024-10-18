using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1movement : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float EnemySpeed = 2f;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        Vector2 direction = (player.position - transform.position);
        rb.MovePosition(rb.S + direction * EnemySpeed);
    }
}
