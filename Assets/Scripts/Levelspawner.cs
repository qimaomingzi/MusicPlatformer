using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelspawner : MonoBehaviour {
    public GameObject platform;
    public float offset = 0.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject block = Instantiate(platform);
            block.transform.position = new Vector2(transform.position.x + offset, transform.position.y);
        }
		
	}
}
