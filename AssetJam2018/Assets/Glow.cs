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

    private void Update()
    {
        if (player.position.x >= leftEdge && player.position.x <= rightEdge)
            spriteRenderer.sprite = spriteGlow;

        if (player.position.x < leftEdge || player.position.x > rightEdge)
            spriteRenderer.sprite = sprite;
    }

}

