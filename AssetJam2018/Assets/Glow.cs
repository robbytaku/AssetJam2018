using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glow : MonoBehaviour
{

    public Sprite sprite;
    public Sprite spriteGlow;
    public SpriteRenderer spriteRenderer;
    public Transform player;
    public float leftEdge;
    public float rightEdge;
    private bool interact;
    public GameObject weapon;
    public bool unlocked = true;
    public bool door = false;

    private void Update()
    {
        if (player.position.x >= leftEdge && player.position.x <= rightEdge)
            interact = true;

        if (player.position.x < leftEdge || player.position.x > rightEdge)
            interact = false;

        if (interact == true) {
            spriteRenderer.sprite = spriteGlow;
        }

        if (interact == false) {
            spriteRenderer.sprite = sprite;
        }
        
    }

}

