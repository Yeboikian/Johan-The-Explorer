﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Schooting : MonoBehaviour
{
    public float Speed;
    public float stoppingDistance;
    public float retreatDistance;

    public Transform player;



    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (Vector2.Distance(transform.position, player.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, Speed * Time.deltaTime);

        } else if (Vector2.Distance(transform.position, player.position) < stoppingDistance && Vector2.Distance(transform.position, player.position) > retreatDistance)
        {
            transform.position = this.transform.position;
        }
        else if(Vector2.Distance(transform.position, player.position)< retreatDistance){

            transform.position = Vector2.MoveTowards(transform.position, player.position, -Speed * Time.deltaTime);
        }

        
    }
}
