using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineBeatMover : MonoBehaviour {
    public float speed = 1.0f;
    public float currentXposition;
    public float lineLimiter;
    public GameObject startingSpot;
    public GameObject beatLine;
    public Vector3 lineStart;
    Collider2D collision;
    Rigidbody2D rb2d;
	// Use this for initialization
	void Start ()
    {
        rb2d = GetComponent<Rigidbody2D>();
        collision = GetComponent<Collider2D>();
	}

    private void FixedUpdate()
    {
        rb2d.velocity = new Vector3(speed * Time.deltaTime, 0, 0);
    }

    // Update is called once per frame
    void Update ()
    {
        lineStart = startingSpot.transform.position;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Linecheckend")
        {
            beatLine.gameObject.transform.position = lineStart;
            rb2d.velocity = new Vector3(speed * Time.deltaTime, 0, 0);
            Debug.Log("It hit");
        }
    }
}
