using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictimOne : MonoBehaviour
{


    public AudioSource soundSmash, screamSound;
    public GameObject meat, slash;

    void Update()
    {

        transform.position = new Vector3(transform.position.x + 0.005f, transform.position.y, transform.position.z);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag.Equals("Chef"))
        {
            soundSmash.Play();
            Instantiate(slash, transform.position - (transform.up * 0.01f), transform.rotation);
            Destroy(gameObject);
            Instantiate(meat, transform.position - (transform.up * 0.1f), transform.rotation);
        }
        if (collision.gameObject.tag.Equals("Projectile"))
        {
            screamSound.Play();
            Destroy(gameObject);
            Instantiate(meat, transform.position - (transform.up * 0.08f), transform.rotation);
        }
    }
}
