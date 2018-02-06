using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineBeatMover : MonoBehaviour {
    public float speed = 1.0f;
    public float currentXposition;
    public float lineLimiter;
    public GameObject startingSpot;
    Collider2D collision;
    Rigidbody2D rb2d;
	// Use this for initialization
	void Start ()
    {
        rb2d = GetComponent<Rigidbody2D>();
        collision = GetComponent<Collider2D>();
        startingSpot = GetComponent<GameObject>();
	}

    private void FixedUpdate()
    {
        rb2d.velocity = new Vector2(speed * Time.deltaTime, 0);
    }

    // Update is called once per frame
    void Update ()
    { 

	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Beatline")
        {
             
            Debug.Log("It hit");
        }
    }
}
