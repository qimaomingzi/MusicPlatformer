using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolidfyPlatforms : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Platform"){
            if(Input.GetKeyDown(KeyCode.Q)){
                //collision.gameObject.GetComponent<BoxCollider2D>().enabled = true;
                Debug.Log("It works");
            }
        }
    }
}
