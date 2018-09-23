using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chef_2_The_Vladenning : MonoBehaviour {

    public Transform[] patrolPoints;
    public float speed;
    public Transform currentPatrolPoint;
    public int currentPatrolIndex;
    public AudioSource soundGrunt, soundSmash, soundLaugh, soundScream;
	public int health = 5;
    public Vector3 patrolPointDir;


    void Start()
    {
        currentPatrolIndex = 0;
        currentPatrolPoint = patrolPoints[currentPatrolIndex];
        StartCoroutine(Laugh());
    }

    IEnumerator Laugh()
    {
        yield return new WaitForSeconds(1.8f);
        soundLaugh.Play();
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



        patrolPointDir = currentPatrolPoint.position - transform.position;
        Vector3 newScale;
       if(currentPatrolIndex == 1)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
            newScale = new Vector3(-1.3f, 1.3f, 1f);
            transform.localScale = newScale;
        }
        if (currentPatrolIndex == 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
            newScale = new Vector3(1.3f, 1.3f, 1f);
            transform.localScale = newScale;

        }

        if (health == 0)
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);

        }

        if (transform.position.x <= -6f)
            currentPatrolIndex = 0;

        if (transform.position.x >= 8.6f)
            currentPatrolIndex = 1;



    }
    //Sound
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag.Equals("Projectile"))
		{ 
			soundGrunt.Play();
			health -= 1;
		}

		if (collision.gameObject.tag.Equals("Villager"))
		{
            speed += 0.05f;
			soundSmash.Play();	
		}

        if (collision.gameObject.tag.Equals("Guy"))
        {
            speed += 0.05f;
            soundSmash.Play();
        }

    }

    IEnumerator Victory()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }



}
