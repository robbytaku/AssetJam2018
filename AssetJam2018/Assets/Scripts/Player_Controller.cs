using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Controller : MonoBehaviour
{


    private Rigidbody2D myRigidbody;

    public Animator myAnimator;
    [SerializeField]
    public float movementSpeed = 1f;
    public GameObject projectile_left, projectile_right;
    public bool facingRight;
    public Transform firePoint;
    public int weapon = 0;
    public SpriteRenderer spriteRenderer_left, spriteRenderer_right;
    public Sprite bottle, knife, blade, pitchfork, heavy;
	public AudioSource throwSound;
    public AudioSource soundSmash;
    public GameObject meat, slash;
    public SpriteRenderer spriteRenderer;
    public BoxCollider2D boxCollider2D;

    void Start()
    {
        facingRight = true;
        myRigidbody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();


    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");

        HandleMovement(horizontal);
        Flip(horizontal);

        if (weapon == 0)
            myAnimator.SetInteger("Weapon", 0);

        if (weapon == 1)
            myAnimator.SetInteger("Weapon", 1);

        if (weapon == 2)
            myAnimator.SetInteger("Weapon", 2);

        if (weapon == 3)
            myAnimator.SetInteger("Weapon", 3);

        if (weapon == 4)
            myAnimator.SetInteger("Weapon", 4);

        if (weapon == 5)
            myAnimator.SetInteger("Weapon", 5);

        if (weapon > 0)
        {
            if(Input.GetKey("space") && facingRight == true) {
				throwSound.Play();
                if (weapon == 1)
                    spriteRenderer_right.sprite = bottle;

                if (weapon == 2)
                    spriteRenderer_right.sprite = knife;

                if (weapon == 3)
                    spriteRenderer_right.sprite = blade;

                if (weapon == 4)
                    spriteRenderer_right.sprite = pitchfork;

                if (weapon == 5)
                    spriteRenderer_right.sprite = heavy;

                Instantiate(projectile_right, transform.position + (transform.right * 0.25f), transform.rotation);
                weapon = 0;

            }
            if(Input.GetKey("space") && facingRight == false)
            {
				throwSound.Play();
				if (weapon == 1)
                    spriteRenderer_left.sprite = bottle;

                if (weapon == 2)
                    spriteRenderer_left.sprite = knife;

                if (weapon == 3)
                    spriteRenderer_left.sprite = blade;

                if (weapon == 4)
                    spriteRenderer_left.sprite = pitchfork;

                if (weapon == 5)
                    spriteRenderer_left.sprite = heavy;

                Instantiate(projectile_left, transform.position - (transform.right * 0.25f), transform.rotation);
                weapon = 0;
            }
                
        }
    }
    private void HandleMovement(float horizontal)
    {

        myRigidbody.velocity = new Vector2(horizontal * movementSpeed, myRigidbody.velocity.y);

        myAnimator.SetFloat("speed", Mathf.Abs(horizontal));
    }

    private void Flip(float horizontal)
    {
        if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight)
        {
            facingRight = !facingRight;

            Vector3 theScale = transform.localScale;

            theScale.x *= -1;

            transform.localScale = theScale;

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Chef"))
        {
            soundSmash.Play();
            Instantiate(slash, transform.position - (transform.up * 0.01f), transform.rotation);
            movementSpeed = 0;
            spriteRenderer.enabled = false;
            boxCollider2D.enabled = false;
            Instantiate(meat, transform.position - (transform.up * 0.15f), transform.rotation);
            StartCoroutine(Death());

        }

        

    }

    IEnumerator Death()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
