using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chef : MonoBehaviour {

    public Transform[] patrolPoints;
    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
	}
}
