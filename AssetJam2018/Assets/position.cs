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

		if (player.transform.position.x <= -3.45f)
			transform.position = new Vector3(-3.45f, transform.position.y, transform.position.z);
		if (player.transform.position.x >= 6.05f)
			transform.position = new Vector3(6.05f, transform.position.y, transform.position.z);
	}
}
