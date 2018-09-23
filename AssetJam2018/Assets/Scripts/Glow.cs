using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glow : MonoBehaviour
{

    public Sprite sprite;
    public Sprite spriteGlow;
    public SpriteRenderer spriteRenderer;
    public SpriteRenderer playerSprite;
    public Transform player;
    public Player_Controller controller;
    public float leftEdge;
    public float rightEdge;
    private bool interact;
    public int weapon;
    public BoxCollider2D playerCollider;
    public bool unlocked = true;
    public bool door = false;
    private bool hidden = false;
	public AudioSource doorLocked, doorOpen, doorClose, weaponBottle, weaponKnife, weaponBlade, weaponPitchfork, weaponHeavy, emptyBox;
    public Chef_2_The_Vladenning chef;
    public Transform chefTransform;
    private float distance;

    private void Update()
    {
        

        distance = (chefTransform.position.x - player.position.x);

        Debug.Log(chef.currentPatrolIndex);

        if (player.position.x >= leftEdge && player.position.x <= rightEdge && hidden == false)
            interact = true;

        if (player.position.x < leftEdge || player.position.x > rightEdge && hidden == false)
            interact = false;


        if (interact == false && hidden == true)
        {
            spriteRenderer.sprite = sprite;
            controller.movementSpeed = 0f;
            if (Input.GetKeyDown("w") || (Input.GetKeyDown("up")))
            {
                
                if (distance > 0f && chef.currentPatrolIndex == 0)
                {
                    chef.currentPatrolIndex = 1;
                }

                if (distance < 0f && chef.currentPatrolIndex == 1)
                {
                    chef.currentPatrolIndex = 0;
                }

                doorClose.Play();
                hidden = false;
                playerSprite.enabled = true;
                playerCollider.enabled = true;
                controller.movementSpeed = 1f;
  

            }
        }

        if (interact == true && hidden == false)
        {
            spriteRenderer.sprite = spriteGlow;
            if (Input.GetKeyDown("w") || (Input.GetKeyDown("up"))){
				if (unlocked == false)
					doorLocked.Play();
				if (weapon == 0 && door == false)
					emptyBox.Play();

				if (weapon == 1 && controller.weapon == 0)
                {
					weaponBottle.Play();
                    controller.weapon = 1;
                    weapon = 0;
                }
                    
                if (weapon == 2 && controller.weapon == 0)
                {
					weaponKnife.Play();
					controller.weapon = 2;
                    weapon = 0;
                }
                    
                if (weapon == 3 && controller.weapon == 0)
                {
					weaponBlade.Play();
					controller.weapon = 3;
                    weapon = 0;
                }
                    
                if (weapon == 4 && controller.weapon == 0)
                {
					weaponPitchfork.Play();
					controller.weapon = 4;
                    weapon = 0;
                }
                    
                if (weapon == 5 && controller.weapon == 0)
                {
					weaponHeavy.Play();
					controller.weapon = 5;
                    weapon = 0;
                }
                    

                if (door == true && unlocked == true)
                {
					doorOpen.Play();
                    hidden = true;
                    playerSprite.enabled = false;
                    playerCollider.enabled = false;
                    interact = false;



                }

            }

        }

        if (interact == false)
            spriteRenderer.sprite = sprite;

    }
}

		
        
    


