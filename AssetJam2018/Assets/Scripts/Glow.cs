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
    public GameObject guy;
    public float leftEdge;
    public float rightEdge;
    private bool interact;
    public GameObject weapon;
    public BoxCollider2D playerCollider;
    public bool unlocked = true;
    public bool door = false;
    private bool hidden = false;

    private void Update()
    {
        if (player.position.x >= leftEdge && player.position.x <= rightEdge)
            interact = true;

        if (player.position.x < leftEdge || player.position.x > rightEdge)
            interact = false;

        if (interact == true) {
            spriteRenderer.sprite = spriteGlow;
            if (Input.GetKeyDown("w") || (Input.GetKeyDown("up")))
                if (door == true){
                    hidden = true;
                    playerSprite.enabled = false;
                    playerCollider.enabled = false;
                }

        }

         

        while (hidden == true){
                //guy.movementSpeed = 0f;
            }
        }
        
    }

}

