﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {

	public GameObject meat;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
	public AudioSource screamSound;
>>>>>>> a76ff8f19a2788b46cb0d514b697e3f4c83af39a
=======
>>>>>>> parent of a76ff8f... asd
=======
>>>>>>> parent of a76ff8f... asd
=======
	public AudioSource screamSound;
>>>>>>> ddc3bc55b16cb7dc0f341d145c5d53398117e471
=======
=======
	public AudioSource screamSound;
>>>>>>> a76ff8f19a2788b46cb0d514b697e3f4c83af39a
>>>>>>> parent of ddc3bc5... Revert "Merge branch 'master' of https://github.com/robbytaku/AssetJam2018"
=======
	public AudioSource screamSound, soundSmash;
	public GameObject slash;
>>>>>>> c95f10b5acdbb195fffc8cb55b39bc1e812b08f5

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	private void OnCollisionEnter2D(Collision2D collision)
	{
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
		screamSound.Play();
>>>>>>> a76ff8f19a2788b46cb0d514b697e3f4c83af39a
=======
>>>>>>> parent of a76ff8f... asd
=======
>>>>>>> parent of a76ff8f... asd
=======
		screamSound.Play();
>>>>>>> ddc3bc55b16cb7dc0f341d145c5d53398117e471
=======
=======
		screamSound.Play();
>>>>>>> a76ff8f19a2788b46cb0d514b697e3f4c83af39a
>>>>>>> parent of ddc3bc5... Revert "Merge branch 'master' of https://github.com/robbytaku/AssetJam2018"
		Destroy(gameObject);
		Instantiate(meat, transform.position - (transform.up * 0.15f), transform.rotation);
=======
		if(collision.gameObject.tag.Equals("Projectile"))
		{ 
			screamSound.Play();
			Destroy(gameObject);
			Instantiate(meat, transform.position - (transform.up * 0.15f), transform.rotation);
		}

		if (collision.gameObject.tag.Equals("Chef"))
		{
			soundSmash.Play();
			Instantiate(slash, transform.position - (transform.up * 0.075f), transform.rotation);
			Destroy(gameObject);
			Instantiate(meat, transform.position - (transform.up * 0.15f), transform.rotation);
		}
>>>>>>> c95f10b5acdbb195fffc8cb55b39bc1e812b08f5
	}
}
