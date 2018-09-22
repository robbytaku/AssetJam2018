using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	void LateUpdate () {
		transform.position = player.transform.position + offset;

		if (player.transform.position.x <= -3.75f)
			transform.position = new Vector3(-3.75f, transform.position.y, transform.position.z);
		//if (player.transform.position.x >= 5.85f)
			//transform.position = new Vector3(5.85f, transform.position.y, transform.position.z);
	}
}
