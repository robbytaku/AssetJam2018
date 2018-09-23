using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {

	public GameObject meat;
	public AudioSource screamSound, soundSmash;
	public GameObject slash;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	private void OnCollisionEnter2D(Collision2D collision)
	{
		screamSound.Play();
		screamSound.Play();
		Destroy(gameObject);
		Instantiate(meat, transform.position - (transform.up * 0.15f), transform.rotation);
		if(collision.gameObject.tag.Equals("Projectile"))
		{ 
			screamSound.Play();
			Destroy(gameObject);
			Instantiate(meat, transform.position - (transform.up * 0.15f), transform.rotation);
		}

		if (collision.gameObject.tag.Equals("Chef"))
		{
			soundSmash.Play();
			Destroy(gameObject);
			Instantiate(meat, transform.position - (transform.up * 0.15f), transform.rotation);
		}
	}
}
