﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour {
    public GameObject playerDeathPrefab;
    public AudioClip deathClip;
    public Sprite hitSprite;
    private SpriteRenderer spriteRenderer;
	// Use this for initialization
    void Awake(){
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Player"){
            var audioSource = GetComponent<AudioSource>();
            if(audioSource !=null && deathClip != null){
                audioSource.PlayOneShot(deathClip);
            }
            Instantiate(playerDeathPrefab,collision.contacts[0].point,Quaternion.identity);
            spriteRenderer.sprite = hitSprite;
            Destroy(collision.gameObject);
            GameManager.instance.RestartLevel(1.25f);
        }
    }
}
