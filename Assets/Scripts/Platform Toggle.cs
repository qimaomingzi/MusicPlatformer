using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformToggle : MonoBehaviour {
    private bool overPlatform;
    Collider2D thisCollision;
    public GameObject currentlyOn;
    BoxCollider2D box2D;
    // Use this for initialization
    void Start ()
    {
    
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.GetKeyDown(KeyCode.Q) && (overPlatform == true)))
        {
            box2D = thisCollision.gameObject.GetComponent<BoxCollider2D>();
            box2D.enabled = true;
        }
	}
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (thisCollision.GetComponent<Collider2D>().tag == "Platform")
        {
            overPlatform = true;
            currentlyOn = thisCollision.gameObject;
        }
    }
}
