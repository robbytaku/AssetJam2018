using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPBAR : MonoBehaviour {

    public SpriteRenderer spriteRenderer;
    public Sprite sprite0, sprite1, sprite2, sprite3, sprite4, sprite5;
    public Chef_2_The_Vladenning chef;

	// Use this for initialization
	
	// Update is called once per frame
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
