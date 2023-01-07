using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class EnemyHard : Enemy
{
    //POLYMORPHISM
    private GameObject player;
    private Rigidbody enemyRb;
    
    //POLYMORPHISM
    protected override void Move()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed);  
    }

    private void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        speed = 3;
    }

    void Update()
    {
        Move();
    }
}