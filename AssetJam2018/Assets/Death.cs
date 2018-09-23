using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {

	public GameObject meat;

	public AudioSource screamSound;


	void Start () {
		
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		screamSound.Play();
		Destroy(gameObject);
		Instantiate(meat, transform.position - (transform.up * 0.15f), transform.rotation);
	}
}
