﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed;
    

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    // Used when performing physice calculation

    void FixedUpdate()
    {

        float moveHorizontal = Input.GetAxis("Horizontal"); // Returns a value between -1 and 1 whenever left, right, a, or d is pushed
        float moveVertical = Input.GetAxis("Vertical"); // Retrun a value between -1 and d1 whenver up, down, w, or s is pushed

        //Debug.("H= " + moveHorizontal + "V= " + moveVertical);

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        Rigidbody2D rBody = this.gameObject.GetComponent<Rigidbody2D>(); // Establishe a "connection" to the rigidbody2D component
        rBody.velocity = movement;
    }

}

