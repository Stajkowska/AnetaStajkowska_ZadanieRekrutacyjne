using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 5;

    public Rigidbody2D rigidBody;
    private Vector2 runDirection;

    private bool playerPresent = false;
    private bool catched = false;
    private string detectionTag = "Player";   

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerPresent && !catched)
        {
            rigidBody.velocity = new Vector2(runDirection.x * speed, runDirection.y * speed);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(detectionTag))
        {
            catched = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(detectionTag)){
            playerPresent = true;
            runDirection = (transform.position - collision.transform.position).normalized;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(detectionTag)){
            playerPresent = false;
        }
    }

}

