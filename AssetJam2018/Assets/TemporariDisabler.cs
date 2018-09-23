using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemporariDisabler : MonoBehaviour {

	public BoxCollider2D colliderStuff;

	// Use this for initialization
	void Start ()
	{
		StartCoroutine(waiter());
	}
	
	IEnumerator waiter()
	{
		colliderStuff.enabled = false;
		yield return new WaitForSeconds(2);
		colliderStuff.enabled = true;
	}

	// Update is called once per frame
	void Update () {
		
	}
}
