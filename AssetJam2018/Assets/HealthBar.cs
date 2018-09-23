using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour {

	public Chef_2_The_Vladenning chef;
	public SpriteRenderer spriteRenderer;
	public Sprite sprite5, sprite4, sprite3, sprite2, sprite1, sprite0;

	void Start () {
		
	}
	
	void Update () {
		if (chef.health == 5)
			spriteRenderer.sprite = sprite5;

		if (chef.health == 4)
			spriteRenderer.sprite = sprite4;

		if (chef.health == 3)
			spriteRenderer.sprite = sprite3;

		if (chef.health == 2)
			spriteRenderer.sprite = sprite2;

		if (chef.health == 1)
			spriteRenderer.sprite = sprite1;

		if (chef.health == 0)
			spriteRenderer.sprite = sprite0;


	}
}
