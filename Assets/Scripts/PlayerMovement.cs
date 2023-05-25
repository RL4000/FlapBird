using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public float jumpForce;
    [SerializeField] public float spinSpeed;
    private Rigidbody2D rb;
    private BoxCollider2D boxColl;
    private SpriteRenderer sprite;
    private Animator anim;
    [SerializeField] private AudioSource jumpSound;
    [SerializeField] private AudioSource deathSound;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        boxColl = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            rb.angularVelocity = spinSpeed * -100;
            jumpSound.time = 0.1f;
            jumpSound.Play();
        }
    }

    void OnCollisionEnter2D(Collision2D colli)
    {
        if (colli.gameObject.CompareTag("Ground") || colli.gameObject.CompareTag("Column")  )
        {
            rb.bodyType = RigidbodyType2D.Static;
            anim.SetTrigger("die");
            deathSound.Play();

        }

    }
}
