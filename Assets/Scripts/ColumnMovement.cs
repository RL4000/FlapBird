using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnMovement : MonoBehaviour
{
    [SerializeField] public float moveSpeed;
    private Rigidbody2D rb;
    private BoxCollider2D boxColl;
    private SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        boxColl = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(-1 * moveSpeed, rb.velocity.y);
    }
    void OnBecameInvisible()
    {
        Debug.Log("despawn1");
        Destroy(gameObject);
    }
}
