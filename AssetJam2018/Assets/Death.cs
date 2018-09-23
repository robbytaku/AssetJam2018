using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {

	public GameObject meat;
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

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	private void OnCollisionEnter2D(Collision2D collision)
	{
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
		Destroy(gameObject);
		Instantiate(meat, transform.position - (transform.up * 0.15f), transform.rotation);
	}
}
