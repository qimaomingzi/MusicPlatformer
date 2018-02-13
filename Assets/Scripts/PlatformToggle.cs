using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformToggle : MonoBehaviour {
    private bool overPlatform;
    BoxCollider2D thisCollision;
    public GameObject currentlyOn;
    BoxCollider2D box2D;
    public GameObject collidedWith;
    // Use this for initialization
    void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.GetKeyDown(KeyCode.Q) && (overPlatform == true)))
        {
            box2D.enabled = true;
        }
	}
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (thisCollision.GetComponent<BoxCollider2D>().tag == "Platform")
        {
            overPlatform = true;
            collidedWith = thisCollision.gameObject;
        }
    }
}
