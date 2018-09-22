﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{


    private Rigidbody2D myRigidbody;

    public Animator myAnimator;
    [SerializeField]
    public float movementSpeed = 1f;

    private bool facingRight;

    public int weapon = 0;

    void Start()
    {
        facingRight = true;
        myRigidbody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();

    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");

        HandleMovement(horizontal);
        Flip(horizontal);

        if (weapon == 0)
            myAnimator.SetInteger("Weapon", 0);
        if (weapon == 1)
            myAnimator.SetInteger("Weapon", 1);
        if (weapon == 2)
            myAnimator.SetInteger("Weapon", 2);
        if (weapon == 3)
            myAnimator.SetInteger("Weapon", 3);
        if (weapon == 4)
            myAnimator.SetInteger("Weapon", 4);
        if (weapon == 5)
            myAnimator.SetInteger("Weapon", 5);
    }
    private void HandleMovement(float horizontal)
    {

        myRigidbody.velocity = new Vector2(horizontal * movementSpeed, myRigidbody.velocity.y);

        myAnimator.SetFloat("speed", Mathf.Abs(horizontal));
    }

    private void Flip(float horizontal)
    {
        if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight)
        {
            facingRight = !facingRight;

            Vector3 theScale = transform.localScale;

            theScale.x *= -1;

            transform.localScale = theScale;

        }
    }
}
