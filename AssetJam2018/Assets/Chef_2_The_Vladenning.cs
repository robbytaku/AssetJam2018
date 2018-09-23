using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chef_2_The_Vladenning : MonoBehaviour {

    public Transform[] patrolPoints;
    public float speed;
    Transform currentPatrolPoint;
    int currentPatrolIndex;


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
    }

  
        
}
