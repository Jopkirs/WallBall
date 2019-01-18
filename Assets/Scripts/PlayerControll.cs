using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour {
    public float movementSpeed = 10f;

    Rigidbody2D rb;
    float movement = 0f;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        movement = Input.GetAxis("Horizontal");
	}

    void FixedUpdate() {
        Vector2 velocity = rb.velocity;
        velocity.x = movement * movementSpeed;
        rb.velocity = velocity;
    }

    public void setVelocityToZero() {
        rb.velocity = new Vector2(0,0);
    }
}
