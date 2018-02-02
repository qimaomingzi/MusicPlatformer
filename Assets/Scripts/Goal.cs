﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {
    public AudioClip goalClip;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player"){
            var audioSource = GetComponent<AudioSource>();
            if(audioSource != null && goalClip != null){
                audioSource.PlayOneShot(goalClip);
            }
            GameManager.instance.RestartLevel(0.5f);
        }
    }
}
