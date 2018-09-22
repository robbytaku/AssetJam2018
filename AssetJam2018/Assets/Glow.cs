using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glow : MonoBehaviour {

	public Sprite sprite;
	public Sprite spriteGlow;
	public SpriteRenderer spriteRenderer;
	public GameObject player;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.name == "Guy")
		{
			spriteRenderer.sprite = spriteGlow;
		}
	

	}
	private void OnCollisionExit2D(Collision2D collision)
	{
		if(collision.gameObject.name == "Guy")
		{
			spriteRenderer.sprite = sprite;
		}
	}

}

