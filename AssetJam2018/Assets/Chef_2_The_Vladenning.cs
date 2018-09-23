﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chef_2_The_Vladenning : MonoBehaviour {

    public Transform[] patrolPoints;
    public float speed;
    Transform currentPatrolPoint;
    int currentPatrolIndex;
	public AudioSource soundGrunt, soundSmash;
	public int health = 5;


    void Start()
    {
        currentPatrolIndex = 0;
        currentPatrolPoint = patrolPoints[currentPatrolIndex];
    }

    void Update()
    {
       
        //Check to see if we have reached patrol point 
        if (Vector3.Distance(transform.position, currentPatrolPoint.position) < .3f)
        {
            // we have reached the patrol point - get the next one

            if (currentPatrolIndex + 1 < patrolPoints.Length)
            {
                currentPatrolIndex++;
            } else {
                currentPatrolIndex = 0;
            }
            currentPatrolPoint = patrolPoints[currentPatrolIndex];
        }


        Vector3 patrolPointDir = currentPatrolPoint.position - transform.position;
        Vector3 newScale;
       if(patrolPointDir.x < 0f)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
            newScale = new Vector3(-1.3f, 1.3f, 1f);
            transform.localScale = newScale;
        }
        if (patrolPointDir.x > 0f)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
            newScale = new Vector3(1.3f, 1.3f, 1f);
            transform.localScale = newScale;

        }
		if (health == 0)
			Destroy(gameObject);
	
    }
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag.Equals("Projectile"))
		{ 
			soundGrunt.Play();
			health -= 1;
		}

		if (collision.gameObject.tag.Equals("Villager"))
		{
			speed += 0.075f;
			soundSmash.Play();	
		}

		if (collision.gameObject.tag.Equals("Guy"))
		{
			speed += 0.075f;
			soundSmash.Play();
		}

	}



}
