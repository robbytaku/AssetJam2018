using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public Vector2 speed;
    public float delay;
    public Player_Controller controller;
    Rigidbody2D rb;
    public SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = speed;

        Destroy(gameObject, delay);
	}
	
	// Update is called once per frame
	void Update () {
        rb.velocity = speed;
    }
}
