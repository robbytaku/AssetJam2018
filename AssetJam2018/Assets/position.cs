using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class position : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	void FixedUpdate () {
		transform.position = player.transform.position + offset;
	}
}
